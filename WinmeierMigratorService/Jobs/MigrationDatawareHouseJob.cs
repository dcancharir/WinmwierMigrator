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
		//account_documents_migration();
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
		daily_meters_migration();
		draw_tickets_migration();
		draws_migration();
		event_history_migration();
		game_meters_migration();
		games_migration();
		general_params_migration();
		gift_instances_migration();
		gui_audit_migration();
		gui_profile_forms_migration();
		gui_users_migration();
		h_m2d_smh_migration();
		h_m2d_tmh_migration();
		h_pvh_migration();
		h_t2d_smh_migration();
		h_t2d_tmh_migration();
		h_w2d_smh_migration();
		h_w2d_tmh_migration();
		h_x2d_control_migration();
		h_y2d_smh_migration();
		h_y2d_tmh_migration();
		handpays_migration();
		historical_generated_patterns_migration();
		invalid_play_sessions_to_player_tracking_migration();
		mailing_instances_migration();
		mb_movements_migration();
		mobile_banks_migration();
		money_collection_meters_migration();
		money_collections_migration();
		occupations_migration();
		play_sessions_migration();
		plays_migration();
		promotions_migration();
		providers_games_migration();
		sales_per_hour_migration();
		sas_meters_adjustments_migration();
		software_validations_migration();
		terminal_game_translation_migration();
		terminal_groups_migration();
		terminal_money_migration();
		terminal_sas_meters_migration();
		terminal_sas_meters_history_migration();
		terminals_migration();
		terminals_connected_migration();
		tickets_audit_status_change_migration();
		wc2_messages_migration();
		wc2_sessions_migration();
		wcp_commands_migration();
		wkt_resources_migration();
		wxp_001_messages_migration();
		return Task.CompletedTask;
    }
    internal void account_documents_migration()
    {
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/account_documents";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/winmeiermigration/account_documents_save");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/account_movements_save";
            var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/account_movements");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/account_operations_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/account_operations");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/account_promotions_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/account_promotions");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/accounts_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/winmeiermigration/accounts");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/alarm_catalog_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/alarm_catalog");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/alarms_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/alarms");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/accounts_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/winmeiermigration/accounts");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/aml_monthly_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/winmeiermigration/aml_monthly");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/areas_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/areas");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/banks_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/banks");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/bonuses_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/bonuses");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/c2_cards_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/c2_cards");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/cage_concept_movement_detail_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/cage_concept_movement_detail");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/cage_movement_details_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/cage_movement_details");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/cage_movements_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/cage_movements");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/cage_session_meters_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/cage_session_meters");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/cashier_movements_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/cashier_movements");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/cashier_movements_grouped_by_hour_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/cashier_movements_grouped_by_hour");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/cashier_sessions_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/cashier_sessions");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/cashier_sessions_by_currency_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/cashier_sessions_by_currency");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/cashier_vouchers_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/cashier_vouchers");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/customer_bucket_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/customer_bucket");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/customer_record_details_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/customer_record_details");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/customer_record_details_history_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/customer_record_details_history");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/customer_records_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/customer_records");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/customer_records_history_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/customer_records_history");
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
			string uri = $"{urlDataWareHouse}api/winmeiermigration/customers_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/customers");
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
	internal void daily_meters_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/daily_meters_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/winmeiermigration/daily_meters");
			int totalForMigration = lastCreated == null ? _context.daily_meters.Count() : _context.daily_meters.Where(x => x.Date > lastCreated).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"daily_meters_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = lastCreated == null ?
					_context.daily_meters.Skip(startIndex).Take(batchSize).ToList() :
					_context.daily_meters.Where(x => x.Date >= lastCreated).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"daily_meters_migration {ex.Message}");
		}
	}
	internal void draw_tickets_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/draw_tickets_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/draw_tickets");
			var totalForMigration = _context.draw_tickets.Where(x => x.dt_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"draw_tickets_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.draw_tickets.Where(x => x.dt_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"draw_tickets_migration {ex.Message}");
		}
	}
	internal void draws_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/draws_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/draws");
			var totalForMigration = _context.draws.Where(x => x.dr_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"draws_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.draws.Where(x => x.dr_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"draws_migration {ex.Message}");
		}
	}
	internal void event_history_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/event_history_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/event_history");
			var totalForMigration = _context.event_histories.Where(x => x.eh_event_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"event_history_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.event_histories.Where(x => x.eh_event_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"event_history_migration {ex.Message}");
		}
	}
	internal void game_meters_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/game_meters_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/game_meters");
			var totalLocal = _context.game_meters.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"game_meters_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.game_meters.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"game_meters_migration {ex.Message}");
		}
	}
	internal void games_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/games_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/games");
			var totalLocal = _context.games.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"games_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.games.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"games_migration {ex.Message}");
		}
	}
	internal void general_params_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/general_params_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/general_params");
			var totalLocal = _context.general_params.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"general_params_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.general_params.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"general_params_migration {ex.Message}");
		}
	}
	internal void gift_instances_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/gift_instances_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/gift_instances");
			var totalForMigration = _context.gift_instances.Where(x => x.gin_gift_instance_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"gift_instances_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.gift_instances.Where(x => x.gin_gift_instance_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"gift_instances_migration {ex.Message}");
		}
	}
	internal void gui_audit_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/gui_audit_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/winmeiermigration/gui_audit");
			int totalForMigration = lastCreated == null ? _context.gui_audits.Count() : _context.gui_audits.Where(x => x.ga_datetime > lastCreated).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"gui_audit_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = lastCreated == null ?
					_context.gui_audits.Skip(startIndex).Take(batchSize).ToList() :
					_context.gui_audits.Where(x => x.ga_datetime >= lastCreated).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"gui_audit_migration {ex.Message}");
		}
	}
	internal void gui_profile_forms_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/gui_profile_forms_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/gui_profile_forms");
			var totalLocal = _context.gui_profile_forms.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"gui_profile_forms_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.gui_profile_forms.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"gui_profile_forms_migration {ex.Message}");
		}
	}
	internal void gui_users_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/gui_users_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/gui_users");
			var totalLocal = _context.gui_users.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"gui_users_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.gui_users.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"gui_users_migration {ex.Message}");
		}
	}
	internal void h_m2d_smh_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/h_m2d_smh_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/h_m2d_smh");
			var totalLocal = _context.h_m2d_smhs.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"h_m2d_smh_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.h_m2d_smhs.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"h_m2d_smh_migration {ex.Message}");
		}
	}
	internal void h_m2d_tmh_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/h_m2d_tmh_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/h_m2d_tmh");
			var totalLocal = _context.h_m2d_tmhs.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"h_m2d_tmh_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.h_m2d_tmhs.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"h_m2d_tmh_migration {ex.Message}");
		}
	}
	internal void h_pvh_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/h_pvh_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/h_pvh");
			var totalLocal = _context.h_pvhs.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"h_pvh_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.h_pvhs.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"h_pvh_migration {ex.Message}");
		}
	}
	internal void h_t2d_smh_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/h_t2d_smh_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/h_t2d_smh");
			var totalLocal = _context.h_t2d_smhs.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"h_t2d_smh_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.h_t2d_smhs.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"h_t2d_smh_migration {ex.Message}");
		}
	}
	internal void h_t2d_tmh_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/h_t2d_tmh_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/h_t2d_tmh");
			var totalLocal = _context.h_t2d_tmhs.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"h_t2d_tmh_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.h_t2d_tmhs.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"h_t2d_tmh_migration {ex.Message}");
		}
	}
	internal void h_w2d_smh_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/h_w2d_smh_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/h_w2d_smh");
			var totalLocal = _context.h_w2d_smhs.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"h_w2d_smh_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.h_w2d_smhs.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"h_w2d_smh_migration {ex.Message}");
		}
	}
	internal void h_w2d_tmh_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/h_w2d_tmh_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/h_w2d_tmh");
			var totalLocal = _context.h_w2d_tmhs.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"h_w2d_tmh_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.h_w2d_tmhs.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"h_w2d_tmh_migration {ex.Message}");
		}
	}
	internal void h_x2d_control_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/h_x2d_control_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/h_x2d_control");
			var totalLocal = _context.h_x2d_controls.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"h_x2d_control_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.h_x2d_controls.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"h_x2d_control_migration {ex.Message}");
		}
	}
	internal void h_y2d_smh_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/h_y2d_smh_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/h_y2d_smh");
			var totalLocal = _context.h_y2d_smhs.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"h_y2d_smh_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.h_y2d_smhs.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"h_y2d_smh_migration {ex.Message}");
		}
	}
	internal void h_y2d_tmh_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/h_y2d_tmh_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/h_y2d_tmh");
			var totalLocal = _context.h_y2d_tmhs.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"h_y2d_tmh_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.h_y2d_tmhs.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"h_y2d_tmh_migration {ex.Message}");
		}
	}
	internal void handpays_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/handpays_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/handpays");
			var totalForMigration = _context.handpays.Where(x => x.hp_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"handpays_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.handpays.Where(x => x.hp_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"handpays_migration {ex.Message}");
		}
	}
	internal void historical_generated_patterns_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/historical_generated_patterns_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/historical_generated_patterns");
			var totalForMigration = _context.historical_generated_patterns.Where(x => x.hgp_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"historical_generated_patterns_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.historical_generated_patterns.Where(x => x.hgp_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"historical_generated_patterns_migration {ex.Message}");
		}
	}
	internal void invalid_play_sessions_to_player_tracking_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/invalid_play_sessions_to_player_tracking_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/invalid_play_sessions_to_player_tracking");
			var totalForMigration = _context.invalid_play_sessions_to_player_trackings.Where(x => x.ips_unique_ud >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"invalid_play_sessions_to_player_tracking_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.invalid_play_sessions_to_player_trackings.Where(x => x.ips_unique_ud >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"invalid_play_sessions_to_player_tracking_migration {ex.Message}");
		}
	}
	internal void mailing_instances_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/mailing_instances_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/mailing_instances");
			var totalForMigration = _context.mailing_instances.Where(x => x.mi_mailing_instance_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"mailing_instances_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.mailing_instances.Where(x => x.mi_mailing_instance_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"mailing_instances_migration {ex.Message}");
		}
	}
	internal void mb_movements_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/mb_movements_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/mb_movements");
			var totalForMigration = _context.mb_movements.Where(x => x.mbm_movement_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"mb_movements_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.mb_movements.Where(x => x.mbm_movement_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"mb_movements_migration {ex.Message}");
		}
	}
	internal void mobile_banks_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/mobile_banks_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/mobile_banks");
			var totalForMigration = _context.mobile_banks.Where(x => x.mb_account_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"mobile_banks_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.mobile_banks.Where(x => x.mb_account_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"mobile_banks_migration {ex.Message}");
		}
	}
	internal void money_collection_meters_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/money_collection_meters_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/money_collection_meters");
			var totalLocal = _context.money_collection_meters.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"money_collection_meters_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.money_collection_meters.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"money_collection_meters_migration {ex.Message}");
		}
	}
	internal void money_collections_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/money_collections_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/money_collections");
			var totalForMigration = _context.money_collections.Where(x => x.mc_collection_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"money_collections_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.money_collections.Where(x => x.mc_collection_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"money_collections_migration {ex.Message}");
		}
	}
	internal void occupations_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/occupations_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/occupations");
			var totalForMigration = _context.occupations.Where(x => x.oc_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"occupations_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.occupations.Where(x => x.oc_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"occupations_migration {ex.Message}");
		}
	}
	internal void play_sessions_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/play_sessions_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/play_sessions");
			var totalForMigration = _context.play_sessions.Where(x => x.ps_play_session_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"play_sessions_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.play_sessions.Where(x => x.ps_play_session_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"play_sessions_migration {ex.Message}");
		}
	}
	internal void plays_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/plays_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/plays");
			var totalForMigration = _context.plays.Where(x => x.pl_play_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"plays_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.plays.Where(x => x.pl_play_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"plays_migration {ex.Message}");
		}
	}
	internal void promotions_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/promotions_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/promotions");
			var totalForMigration = _context.promotions.Where(x => x.pm_promotion_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"promotions_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.promotions.Where(x => x.pm_promotion_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"promotions_migration {ex.Message}");
		}
	}
	internal void providers_games_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/providers_games_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/providers_games");
			var totalForMigration = _context.providers_games.Where(x => x.pg_game_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"providers_games_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.providers_games.Where(x => x.pg_game_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"providers_games_migration {ex.Message}");
		}
	}
	internal void sales_per_hour_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/sales_per_hour_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/sales_per_hour");
			var totalForMigration = _context.sales_per_hours.Where(x => x.sph_unique_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"sales_per_hour_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.sales_per_hours.Where(x => x.sph_unique_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"sales_per_hour_migration {ex.Message}");
		}
	}
	internal void sas_meters_adjustments_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/sas_meters_adjustments_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/sas_meters_adjustments");
			var totalForMigration = _context.sas_meters_adjustments.Where(x => x.tma_unique_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"sas_meters_adjustments_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.sas_meters_adjustments.Where(x => x.tma_unique_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"sas_meters_adjustments_migration {ex.Message}");
		}
	}
	internal void software_validations_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/software_validations_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/software_validations");
			var totalForMigration = _context.software_validations.Where(x => x.sval_validation_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"software_validations_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.software_validations.Where(x => x.sval_validation_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"software_validations_migration {ex.Message}");
		}
	}
	internal void terminal_game_translation_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/terminal_game_translation_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/winmeiermigration/terminal_game_translation");
			int totalForMigration = lastCreated == null ? _context.terminal_game_translations.Count() : _context.terminal_game_translations.Where(x => x.tgt_created > lastCreated).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"terminal_game_translation_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = lastCreated == null ?
					_context.terminal_game_translations.Skip(startIndex).Take(batchSize).ToList() :
					_context.terminal_game_translations.Where(x => x.tgt_created >= lastCreated).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"terminal_game_translation_migration {ex.Message}");
		}
	}
	internal void terminal_groups_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/terminal_groups_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/terminal_groups");
			var totalLocal = _context.terminal_groups.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"terminal_groups_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.terminal_groups.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"terminal_groups_migration {ex.Message}");
		}
	}
	internal void terminal_money_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/terminal_money_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/terminal_money");
			var totalLocal = _context.terminal_moneys.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"terminal_money_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.terminal_moneys.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"terminal_money_migration {ex.Message}");
		}
	}
	internal void terminal_sas_meters_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/terminal_sas_meters_save";
			var total = GetTotal($"{urlDataWareHouse}api/winmeiermigration/terminal_sas_meters");
			var totalLocal = _context.terminal_sas_meters.Count();
			int totalForMigration = total == totalLocal ? 0 : totalLocal;
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"terminal_sas_meters_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.terminal_sas_meters.Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"terminal_sas_meters_migration {ex.Message}");
		}
	}
	internal void terminal_sas_meters_history_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/terminal_sas_meters_history_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/winmeiermigration/terminal_sas_meters_history");
			int totalForMigration = lastCreated == null ? _context.terminal_sas_meters_histories.Count() : _context.terminal_sas_meters_histories.Where(x => x.tsmh_created_datetime > lastCreated).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"terminal_sas_meters_history_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = lastCreated == null ?
					_context.terminal_sas_meters_histories.Skip(startIndex).Take(batchSize).ToList() :
					_context.terminal_sas_meters_histories.Where(x => x.tsmh_created_datetime >= lastCreated).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"terminal_sas_meters_history_migration {ex.Message}");
		}
	}
	internal void terminals_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/terminals_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/terminals");
			var totalForMigration = _context.terminals.Where(x => x.te_terminal_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"terminals_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.terminals.Where(x => x.te_terminal_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"terminals_migration {ex.Message}");
		}
	}
	internal void terminals_connected_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/terminals_connected_save";
			var lastCreated = GetLastCreated($"{urlDataWareHouse}api/winmeiermigration/terminals_connected");
			int totalForMigration = lastCreated == null ? _context.terminals_connecteds.Count() : _context.terminals_connecteds.Where(x => x.tc_date > lastCreated).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"terminals_connected_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = lastCreated == null ?
					_context.terminals_connecteds.Skip(startIndex).Take(batchSize).ToList() :
					_context.terminals_connecteds.Where(x => x.tc_date >= lastCreated).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"terminals_connected_migration {ex.Message}");
		}
	}
	internal void tickets_audit_status_change_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/tickets_audit_status_change_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/tickets_audit_status_change");
			var totalForMigration = _context.tickets_audit_status_changes.Where(x => x.tia_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"tickets_audit_status_change_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.tickets_audit_status_changes.Where(x => x.tia_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"tickets_audit_status_change_migration {ex.Message}");
		}
	}
	internal void wc2_messages_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/wc2_messages_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/wc2_messages");
			var totalForMigration = _context.wc2_messages.Where(x => x.w2m_message_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"wc2_messages_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.wc2_messages.Where(x => x.w2m_message_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"wc2_messages_migration {ex.Message}");
		}
	}
	internal void wc2_sessions_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/wc2_sessions_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/wc2_sessions");
			var totalForMigration = _context.wc2_sessions.Where(x => x.w2s_session_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"wc2_sessions_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.wc2_sessions.Where(x => x.w2s_session_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"wc2_sessions_migration {ex.Message}");
		}
	}
	internal void wcp_commands_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/wcp_commands_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/wcp_commands");
			var totalForMigration = _context.wcp_commands.Where(x => x.cmd_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"wcp_commands_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.wcp_commands.Where(x => x.cmd_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"wcp_commands_migration {ex.Message}");
		}
	}
	internal void wkt_resources_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/wkt_resources_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/wkt_resources");
			var totalForMigration = _context.wkt_resources.Where(x => x.res_resource_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"wkt_resources_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.wkt_resources.Where(x => x.res_resource_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"wkt_resources_migration {ex.Message}");
		}
	}
	internal void wxp_001_messages_migration()
	{
		try
		{
			string uri = $"{urlDataWareHouse}api/winmeiermigration/wxp_001_messages_save";
			var lastId = GetLastId($"{urlDataWareHouse}api/winmeiermigration/wxp_001_messages");
			var totalForMigration = _context.wxp_001_messages.Where(x => x.wxm_id >= lastId).Count();
			var batchCount = (totalForMigration + batchSize - 1) / batchSize;
			_logger.LogInformation($"wxp_001_messages_migration total for migration : {totalForMigration}");
			for(int i = 0; i < batchCount; i++)
			{
				int intentos = 100;
				var startIndex = i * batchSize;
				var data = _context.wxp_001_messages.Where(x => x.wxm_id >= lastId).Skip(startIndex).Take(batchSize).ToList();
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
			_logger.LogError($"wxp_001_messages_migration {ex.Message}");
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
		bool response = false;
		try
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
						response = JsonConvert.DeserializeObject<bool>(result);
						//return jsonResult;
					}
				}
			}
			return response;
		} catch(Exception ex)
		{
			_logger.LogError($"Method DataWarehouseSave() uri : {uri} - message : {ex.Message}");
			return false;
		}
		
	}
}
