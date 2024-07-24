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
    private readonly int batchSize = 1000;
    private string urlDataWareHouse = string.Empty;
    private readonly int milisecondsToWait = 1000;
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
		account_documents_migration();
		account_movements_migration();
		account_operations_migration();
		account_promotions_migration();
		accounts_migration();

		return Task.CompletedTask;
    }
    internal void account_documents_migration()
    {
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/account_documents";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/migration/account_documents_save");
			int totalForMigration = lastCreated == null ? _context.account_documents.Count() : _context.account_documents.Where(x => x.ad_created >= lastCreated).Count();
			var batchCount = (totalForMigration + 10 - 1) / 10;
			_logger.LogInformation($"account_documents_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * 10;
				var data = lastCreated == null ?
					_context.account_documents.Skip(startIndex).Take(10).ToList() :
					_context.account_documents.Where(x => x.ad_created >= lastCreated).Skip(startIndex).Take(10).ToList();
				while(intentos > 0)
				{
					object oEnvio = data;
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
			_logger.LogInformation($"account_movements_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.account_movements.Where(x => x.am_movement_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
				while(intentos > 0)
				{
					object oEnvio = data;
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
	internal void account_operations_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/account_operations_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/account_operations");
			var totalForMigration = _context.account_operations.Where(x => x.ao_operation_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"account_operations_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.account_operations.Where(x => x.ao_operation_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
				while(intentos > 0)
				{
					object oEnvio = data;
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
			_logger.LogError($"account_operations_migration {ex.Message}");
		}
	}
	internal void account_promotions_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/account_promotions_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/account_promotions");
			var totalForMigration = _context.account_promotions.Where(x => x.acp_unique_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"account_promotions_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.account_promotions.Where(x => x.acp_unique_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
				while(intentos > 0)
				{
					object oEnvio = data;
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
			_logger.LogError($"account_promotions_migration {ex.Message}");
		}
	}
	internal void accounts_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/accounts_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/migration/accounts");
			int totalForMigration = lastCreated == null? _context.accounts.Count() : _context.accounts.Where(x => x.ac_created > lastCreated).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"accounts_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = lastCreated == null ? 
					_context.accounts.Skip(startIndex).Take(batchSize).ToList() : 
					_context.accounts.Where(x => x.ac_created >= lastCreated).Skip(startIndex).Take(batchSize).ToList();
				while(intentos > 0)
				{
					object oEnvio = data;
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
			_logger.LogError($"accounts_migration {ex.Message}");
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
	internal DateTime? GetLastCreated(string uri)
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
					var jsonResult = JsonConvert.DeserializeObject<DateTime?>(result);
					return jsonResult;
				}
			}
		}
		return null;
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
}
