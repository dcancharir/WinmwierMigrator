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
		alarm_catalog_migration();
		alarms_migration();
		aml_daily_migration();
		aml_monthly_migration();
		areas_migration();
		banks_migration();
		bonuses_migration();
		c2_cards_migration();
		cage_concept_movement_detail_migration();
		cage_movement_details_migration();
		cage_movements_migration();
		cage_session_meters_migration();
		cashier_movements_migration();
		cashier_movements_grouped_by_hour_migration();
		cashier_sessions_migration();
		cashier_sessions_by_currency_migration();
		cashier_vouchers_migration();
		customer_bucket_migration();
		customer_record_details_migration();
		customer_record_details_history_migration();
		customer_records_migration();
		customer_records_history_migration();
		customers_migration();
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
	internal void alarm_catalog_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/alarm_catalog_save";
			var total = GetTotal($"{urlDataWareHouse}api/migration/alarm_catalog");
			var totalLocal = _context.alarm_catalogs.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"alarm_catalog_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.alarm_catalogs.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"alarm_catalog_migration {ex.Message}");
		}
	}
	internal void alarms_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/alarms_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/alarms");
			var totalForMigration = _context.alarms.Where(x => x.al_alarm_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"alarms_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.alarms.Where(x => x.al_alarm_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"alarms_migration {ex.Message}");
		}
	}
	internal void aml_daily_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/accounts_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/migration/accounts");
			int totalForMigration = lastCreated == null ? _context.aml_dailies.Count() : _context.aml_dailies.Where(x => x.amd_day > lastCreated).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"aml_daily_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = lastCreated == null ?
					_context.aml_dailies.Skip(startIndex).Take(batchSize).ToList() :
					_context.aml_dailies.Where(x => x.amd_day >= lastCreated).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"aml_daily_migration {ex.Message}");
		}
	}
	internal void aml_monthly_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/aml_monthly_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/migration/aml_monthly");
			int totalForMigration = lastCreated == null ? _context.aml_monthlies.Count() : _context.aml_monthlies.Where(x => x.amm_month  > lastCreated).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"aml_monthly_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = lastCreated == null ?
					_context.aml_monthlies.Skip(startIndex).Take(batchSize).ToList() :
					_context.aml_monthlies.Where(x => x.amm_month >= lastCreated).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"aml_monthly_migration {ex.Message}");
		}
	}
	internal void areas_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/areas_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/areas");
			var totalForMigration = _context.areas.Where(x => x.ar_area_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"areas_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.areas.Where(x => x.ar_area_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"areas_migration {ex.Message}");
		}
	}
	internal void banks_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/banks_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/banks");
			var totalForMigration = _context.banks.Where(x => x.bk_bank_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"banks_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.banks.Where(x => x.bk_bank_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"banks_migration {ex.Message}");
		}
	}
	internal void bonuses_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/bonuses_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/bonuses");
			var totalForMigration = _context.bonuses.Where(x => x.bns_bonus_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"bonuses_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.bonuses.Where(x => x.bns_bonus_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"bonuses_migration {ex.Message}");
		}
	}
	internal void c2_cards_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/c2_cards_save";
			var total = GetTotal($"{urlDataWareHouse}api/migration/c2_cards");
			var totalLocal = _context.c2_cards.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"c2_cards_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.c2_cards.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"c2_cards_migration {ex.Message}");
		}
	}
	internal void cage_concept_movement_detail_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/cage_concept_movement_detail_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/cage_concept_movement_detail");
			var totalForMigration = _context.cage_concept_movement_details.Where(x => x.ccmd_cage_concept_movement_detail_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"cage_concept_movement_detail_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.cage_concept_movement_details.Where(x => x.ccmd_cage_concept_movement_detail_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"cage_concept_movement_detail_migration {ex.Message}");
		}
	}
	internal void cage_movement_details_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/cage_movement_details_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/cage_movement_details");
			var totalForMigration = _context.cage_movement_details.Where(x => x.cmd_cage_movement_detail_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"cage_movement_details_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.cage_movement_details.Where(x => x.cmd_cage_movement_detail_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"cage_movement_details_migration {ex.Message}");
		}
	}
	internal void cage_movements_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/cage_movements_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/cage_movements");
			var totalForMigration = _context.cage_movements.Where(x => x.cgm_movement_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"cage_movements_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.cage_movements.Where(x => x.cgm_movement_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"cage_movements_migration {ex.Message}");
		}
	}
	internal void cage_session_meters_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/cage_session_meters_save";
			var total = GetTotal($"{urlDataWareHouse}api/migration/cage_session_meters");
			var totalLocal = _context.cage_session_meters.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"cage_session_meters_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.cage_session_meters.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"cage_session_meters_migration {ex.Message}");
		}
	}
	internal void cashier_movements_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/cashier_movements_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/cashier_movements");
			var totalForMigration = _context.cashier_movements.Where(x => x.cm_movement_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"cashier_movements_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.cashier_movements.Where(x => x.cm_movement_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"cashier_movements_migration {ex.Message}");
		}
	}
	internal void cashier_movements_grouped_by_hour_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/cashier_movements_grouped_by_hour_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/cashier_movements_grouped_by_hour");
			var totalForMigration = _context.cashier_movements_grouped_by_hours.Where(x => x.cm_unique_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"cashier_movements_grouped_by_hour_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.cashier_movements_grouped_by_hours.Where(x => x.cm_unique_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"cashier_movements_grouped_by_hour_migration {ex.Message}");
		}
	}
	internal void cashier_sessions_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/cashier_sessions_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/cashier_sessions");
			var totalForMigration = _context.cashier_sessions.Where(x => x.cs_session_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"cashier_sessions_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.cashier_sessions.Where(x => x.cs_session_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"cashier_sessions_migration {ex.Message}");
		}
	}
	internal void cashier_sessions_by_currency_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/cashier_sessions_by_currency_save";
			var total = GetTotal($"{urlDataWareHouse}api/migration/cashier_sessions_by_currency");
			var totalLocal = _context.cashier_sessions_by_currencies.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"cashier_sessions_by_currency_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.cashier_sessions_by_currencies.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"cashier_sessions_by_currency_migration {ex.Message}");
		}
	}
	internal void cashier_vouchers_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/cashier_vouchers_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/cashier_vouchers");
			var totalForMigration = _context.cashier_vouchers.Where(x => x.cv_voucher_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"cashier_vouchers_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.cashier_vouchers.Where(x => x.cv_voucher_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"cashier_vouchers_migration {ex.Message}");
		}
	}
	internal void customer_bucket_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/customer_bucket_save";
			var total = GetTotal($"{urlDataWareHouse}api/migration/customer_bucket");
			var totalLocal = _context.customer_buckets.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"customer_bucket_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.customer_buckets.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"customer_bucket_migration {ex.Message}");
		}
	}
	internal void customer_record_details_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/customer_record_details_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/customer_record_details");
			var totalForMigration = _context.customer_record_details.Where(x => x.curd_detail_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"customer_record_details_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.customer_record_details.Where(x => x.curd_detail_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"customer_record_details_migration {ex.Message}");
		}
	}
	internal void customer_record_details_history_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/customer_record_details_history_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/customer_record_details_history");
			var totalForMigration = _context.customer_record_details_histories.Where(x => x.curdh_detail_history_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"customer_record_details_history_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.customer_record_details_histories.Where(x => x.curdh_detail_history_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"customer_record_details_history_migration {ex.Message}");
		}
	}
	internal void customer_records_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/customer_records_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/customer_records");
			var totalForMigration = _context.customer_records.Where(x => x.cur_record_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"customer_records_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.customer_records.Where(x => x.cur_record_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"customer_records_migration {ex.Message}");
		}
	}
	internal void customer_records_history_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/customer_records_history_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/migration/customer_records_history");
			var totalForMigration = _context.customer_records_histories.Where(x => x.curh_record_history_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"customer_records_history_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.customer_records_histories.Where(x => x.curh_record_history_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"customer_records_history_migration {ex.Message}");
		}
	}
	internal void customers_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/migration/customers_save";
			var total = GetTotal($"{urlDataWareHouse}api/migration/customers");
			var totalLocal = _context.customers.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"customers_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.customers.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"customers_migration {ex.Message}");
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
	internal int GetTotal(string uri)
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
}
