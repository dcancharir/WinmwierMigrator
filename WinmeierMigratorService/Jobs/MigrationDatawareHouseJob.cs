using Newtonsoft.Json;
using Quartz;
using System.Text;
using WinmeierMigratorService.Utilities;
using WinmeierMigratorService.Context;
using System;
using System.Linq.Expressions;

namespace WinmeierMigratorService.Jobs;

public class MigrationDatawareHouseJob : IJob
{
    private readonly wgdb_000Context _context;
    private readonly int batchSize = 10;
    private string urlDataWareHouse = string.Empty;
    private readonly int milisecondsToWait = 5000;
    private readonly ILogger<MigrationDatawareHouseJob> _logger;
	public IConfiguration _configuration;
	public MigrationDatawareHouseJob(wgdb_000Context context, ILogger<MigrationDatawareHouseJob> logger,IConfiguration configuration)
    {
        _context = context ?? throw new ArgumentNullException(nameof(wgdb_000Context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        urlDataWareHouse = Convert.ToString(_configuration.GetValue<string>("Uris:UrlServidorDataWareHouse"));
	}

    public Task Execute(IJobExecutionContext context)
    {
		//Inicio Jobs
		//account_movements_migration
		account_movements_migration();
        return Task.CompletedTask;
    }
    internal void account_documents_migration(List<LastInsertedModel> lastInsertedList)
    {
        try
        {
            string uri = $"{urlDataWareHouse}/api/account_documents_save";
            var lastValueInserted = lastInsertedList.Where(x => x.TableName == "account_documents").First();
            if(lastValueInserted != null)
            {
                var lastValue = Convert.ToInt64(lastValueInserted.LastInsertedValue == null ? 0 : lastValueInserted.LastInsertedValue);
                var totalForMigration = _context.account_documents.Where(x=>x.ad_account_id == lastValue).Count();
                var batchCount = (totalForMigration + batchSize - 1) / batchSize;
                for(int i = 0; i < batchCount; i++)
                {
                    int intentos = 100;
                    var startIndex = i * batchSize;
                    var batch = _context.account_documents.Where(x=>x.ad_account_id >= lastValue).Skip(startIndex).Take(batchSize).ToList();
                    while(intentos > 0)
                    {
                        object oEnvio = new
                        {
                            data = batch,
                        };
                        var respuestaMigracion = DataWareHousePostWithListReturned(oEnvio,uri);
                        if(respuestaMigracion!=null && respuestaMigracion.Count>0)
                        {
                            intentos = 0;
                        } else
                        {
                            intentos--;
                            Task.Delay(milisecondsToWait).Wait();
                        }
                    }
                }

            }
        } catch(Exception ex)
        {
            _logger.LogError($"account_documents_migration {ex.Message}");
        }
    }
    internal void account_movements_migration()
    {
        try
        {
			string uri = $"{urlDataWareHouse}api/migration/account_movements_save";
            var lastId = GetLastId($"{urlDataWareHouse}api/migration/account_movements");
            var totalForMigration = _context.account_movements.Where(x => x.am_movement_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var batch = _context.account_movements.Where(x => x.am_movement_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
				while(intentos > 0)
				{
					object oEnvio = new
					{
						data = batch,
					};
					var respuestaMigracion = DataWarehouseSave(oEnvio, uri);
					if(respuestaMigracion == true)
					{
						intentos = 0;
					} else
					{
						intentos--;
						Task.Delay(milisecondsToWait).Wait();
					}
				}
			}

		} catch(Exception ex)
        {
			_logger.LogError($"account_movements_migration {ex.Message}");
        }
    }
    internal long GetLastId(string uri)
    {
		using(HttpClient httpClient = new HttpClient())
		{
			httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			//var stringContent = new StringContent(JsonConvert.SerializeObject(""), Encoding.UTF8, "application/json");
			using(HttpResponseMessage httpResponse = httpClient.GetAsync($"{uri}").Result)
			{
				if(httpResponse.IsSuccessStatusCode)
				{
					var result = httpResponse.Content.ReadAsStringAsync().Result;
					var jsonResult = JsonConvert.DeserializeObject<int>(result);
					return jsonResult;
				}
			}
		}
		return 0;
	}
    internal bool DataWarehouseSave(object oEnvio, string uri)
    {
		using(HttpClient httpClient = new HttpClient())
		{
			httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			var stringContent = new StringContent(JsonConvert.SerializeObject(oEnvio), Encoding.UTF8, "application/json");
			using(HttpResponseMessage httpResponse = httpClient.PostAsync($"{uri}", stringContent).Result)
			{
				if(httpResponse.IsSuccessStatusCode)
				{
					var result = httpResponse.Content.ReadAsStringAsync().Result;
					var jsonResult = JsonConvert.DeserializeObject<bool>(result);
					return jsonResult;
				}
			}
		}
		return false;
	}
    List<LastInsertedModel> GetLastInserted()
    {
        return new List<LastInsertedModel> { new LastInsertedModel() };
    }
    public List<string>? DataWareHousePostWithListReturned(object oEnvio, string uri)
    {
        using(HttpClient httpClient = new HttpClient())
        {
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var stringContent = new StringContent(JsonConvert.SerializeObject(oEnvio), Encoding.UTF8, "application/json");
            using(HttpResponseMessage httpResponse = httpClient.PostAsync($"{uri}", stringContent).Result)
            {
                if(httpResponse.IsSuccessStatusCode)
                {
                    var result = httpResponse.Content.ReadAsStringAsync().Result;
                    var jsonResult = JsonConvert.DeserializeObject<List<string>>(result);
                    return jsonResult;
                }
            }
        }
        return new List<string>();
    }
}
