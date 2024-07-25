using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using WinmeierDatawareHouseClient.Utilities;
using WinmeierDataWarehouseClient.Context;
using WinmeierDataWarehouseClient.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinmeierDatawareHouseClient.Controllers;
[Route("api/migration")]
[ApiController]
public class MigrationController : ControllerBase
{
	wgdb_000_winmeierContext _context;
	private readonly ILogger<MigrationController> _logger;
	public MigrationController(wgdb_000_winmeierContext context, ILogger<MigrationController> logger)
	{
		_context = context;
		_logger = logger;
	}
	[HttpGet]
	[Route("account_documents")]
	public IActionResult account_documents()
	{
		DateTime? last_created;
		try
		{
			var lastElement = _context.account_documents.OrderByDescending(x => x.ad_created).FirstOrDefault();
			last_created = lastElement?.ad_created;
			return Ok(last_created);

		} catch(Exception)
		{
			return Ok(null);
		}
	}
	[HttpPost]
	[Route("account_documents_save")]
	public IActionResult account_documents_save(List<account_document> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<account_document, bool>> predicate = c => c.ad_account_id == item.ad_account_id;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"account_documents_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("account_movements")]
	public IActionResult account_movements()
	{
		long lastId = 0;
		try
		{
			var lastElement = _context.account_movements.OrderByDescending(x => x.am_movement_id).FirstOrDefault();
			lastId = lastElement == null ? 0 : lastElement.am_movement_id;

		} catch(Exception)
		{
			lastId=0;
		}
		
		return Ok(lastId);
	}
	[HttpPost]
	[Route("account_movements_save")]
	public IActionResult account_movements_save(List<account_movement> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<account_movement, bool>> predicate = c => c.am_movement_id == item.am_movement_id;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"account_movements_save method -> " + ex.Message);
			return Ok(false);
		}

	}
	[HttpGet]
	[Route("account_operations")]
	public IActionResult account_operations()
	{
		long lastId;
		try
		{
			var lastElement = _context.account_operations.OrderByDescending(x => x.ao_operation_id).FirstOrDefault();
			lastId = lastElement == null ? 0 : lastElement.ao_operation_id;
		} catch(Exception)
		{
			lastId = 0;
		}
		return Ok(lastId);
	}
	[HttpPost]
	[Route("account_operations_save")]
	public IActionResult account_operations_save(List<account_operation> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<account_operation, bool>> predicate = c => c.ao_operation_id == item.ao_operation_id;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"account_operations_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("account_promotions")]
	public IActionResult account_promotions()
	{
		long lastId;
		try
		{
			var lastElement = _context.account_promotions.OrderByDescending(x => x.acp_unique_id).FirstOrDefault();
			lastId = lastElement == null ? 0 : lastElement.acp_unique_id;
		} catch(Exception)
		{
			lastId = 0;
		}
		return Ok(lastId);
	}
	[HttpPost]
	[Route("account_promotions_save")]
	public IActionResult account_promotions_save(List<account_promotion> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<account_promotion, bool>> predicate = c => c.acp_unique_id == item.acp_unique_id;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"account_promotions_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("accounts")]
	public IActionResult accounts()
	{
		DateTime? last_created;
		try
		{
			var lastElement = _context.accounts.OrderByDescending(x => x.ac_created).FirstOrDefault();
			last_created = lastElement?.ac_created;
			return Ok(last_created);

		} catch(Exception)
		{
			return Ok(null);
		}

	}
	[HttpPost]
	[Route("accounts_save")]
	public IActionResult accounts_save(List<account> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<account, bool>> predicate = c => c.ac_account_id == item.ac_account_id;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"accounts_save method -> " + ex.Message);
			return Ok(false);
		}
	}
    [HttpGet]
    [Route("alarm_catalog")]
    public IActionResult alarm_catalog()
    {
        int total;
        try
        {
            total = _context.alarm_catalogs.Count();
            return Ok(total);

        } catch(Exception)
        {
            return Ok(0);
        }

    }
	[HttpPost]
	[Route("alarm_catalog_save")]
	public IActionResult alarm_catalog_save(List<alarm_catalog> data)
	{
        try
        {
            foreach(var item in data)
            {
                Expression<Func<alarm_catalog, bool>> predicate = c => c.alcg_alarm_code == item.alcg_alarm_code && c.alcg_language_id == item.alcg_language_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"alarm_catalog_save method -> " + ex.Message);
            return Ok(false);
        }
    }
	[HttpGet]
	[Route("alarms")]
	public IActionResult alarms()
	{
        long lastId = 0;
        try
        {
            var lastElement = _context.alarms.OrderByDescending(x => x.al_alarm_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.al_alarm_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
	[HttpPost]
	[Route("alarms_save")]
	public IActionResult alarms_save(List<alarm> data)
	{
        try
        {
            foreach(var item in data)
            {
                Expression<Func<alarm, bool>> predicate = c => c.al_alarm_id == item.al_alarm_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"alarms_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("aml_daily")]
    public IActionResult aml_daily()
    {
        DateTime? last_created;
        try
        {
            var lastElement = _context.aml_dailies.OrderByDescending(x => x.amd_day).FirstOrDefault();
            last_created = lastElement?.amd_day;
            return Ok(last_created);

        } catch(Exception)
        {
            return Ok(null);
        }
    }
    [HttpPost]
    [Route("aml_daily_save")]
    public IActionResult aml_daily_save(List<aml_daily> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<aml_daily, bool>> predicate = c => c.amd_day == item.amd_day && c.amd_account_id == item.amd_account_id && c.amd_track_data == item.amd_track_data;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"aml_daily_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("aml_monthly")]
    public IActionResult aml_monthly()
    {
        DateTime? last_created;
        try
        {
            var lastElement = _context.aml_monthlies.OrderByDescending(x => x.amm_month).FirstOrDefault();
            last_created = lastElement?.amm_month;
            return Ok(last_created);

        } catch(Exception)
        {
            return Ok(null);
        }
    }
    [HttpPost]
    [Route("aml_monthly_save")]
    public IActionResult aml_monthly_save(List<aml_monthly> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<aml_monthly, bool>> predicate = c => c.amm_month == item.amm_month && c.amm_account_id == item.amm_account_id && c.amm_track_data == item.amm_track_data;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"aml_monthly_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("areas")]
    public IActionResult areas()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.areas.OrderByDescending(x => x.ar_area_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.ar_area_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("areas_save")]
    public IActionResult areas_save(List<area> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<area, bool>> predicate = c => c.ar_area_id == item.ar_area_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"areas_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("banks")]
    public IActionResult banks()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.banks.OrderByDescending(x => x.bk_bank_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.bk_bank_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("banks_save")]
    public IActionResult banks_save(List<bank> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<bank, bool>> predicate = c => c.bk_bank_id == item.bk_bank_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"banks_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("bonuses")]
    public IActionResult bonuses()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.bonuses.OrderByDescending(x => x.bns_bonus_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.bns_bonus_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("bonuses_save")]
    public IActionResult bonuses_save(List<bonuse> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<bonuse, bool>> predicate = c => c.bns_bonus_id == item.bns_bonus_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"bonuses_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("c2_cards")]
    public IActionResult c2_cards()
    {
        int total;
        try
        {
            total = _context.c2_cards.Count();
            return Ok(total);

        } catch(Exception)
        {
            return Ok(0);
        }

    }
    [HttpPost]
    [Route("c2_cards_save")]
    public IActionResult c2_cards_save(List<c2_card> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<c2_card, bool>> predicate = c => c.c2c_card_id == item.c2c_card_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"c2_cards_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("cage_concept_movement_detail")]
    public IActionResult cage_concept_movement_detail()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.cage_concept_movement_details.OrderByDescending(x => x.ccmd_cage_concept_movement_detail_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.ccmd_cage_concept_movement_detail_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("cage_concept_movement_detail_save")]
    public IActionResult cage_concept_movement_detail_save(List<cage_concept_movement_detail> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<cage_concept_movement_detail, bool>> predicate = c => c.ccmd_cage_concept_movement_detail_id == item.ccmd_cage_concept_movement_detail_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"cage_concept_movement_detail_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("cage_movement_details")]
    public IActionResult cage_movement_details()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.cage_movement_details.OrderByDescending(x => x.cmd_cage_movement_detail_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.cmd_cage_movement_detail_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("cage_movement_details_save")]
    public IActionResult cage_movement_details_save(List<cage_movement_detail> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<cage_movement_detail, bool>> predicate = c => c.cmd_cage_movement_detail_id == item.cmd_cage_movement_detail_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"cage_movement_details_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("cage_movements")]
    public IActionResult cage_movements()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.cage_movements.OrderByDescending(x => x.cgm_movement_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.cgm_movement_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("cage_movements_save")]
    public IActionResult cage_movements_save(List<cage_movement> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<cage_movement, bool>> predicate = c => c.cgm_movement_id == item.cgm_movement_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"cage_movements_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("cage_session_meters")]
    public IActionResult cage_session_meters()
    {
        int total;
        try
        {
            total = _context.cage_session_meters.Count();
            return Ok(total);

        } catch(Exception)
        {
            return Ok(0);
        }

    }
    [HttpPost]
    [Route("cage_session_meters_save")]
    public IActionResult cage_session_meters_save(List<cage_session_meter> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<cage_session_meter, bool>> predicate = c => 
                    c.csm_cage_session_id == item.csm_cage_session_id && 
                    c.csm_source_target_id == item.csm_source_target_id &&
                    c.csm_concept_id == item.csm_concept_id &&
                    c.csm_iso_code == item.csm_iso_code &&
                    c.csm_cage_currency_type == item.csm_cage_currency_type
                    ;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"cage_session_meters_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("cashier_movements")]
    public IActionResult cashier_movements()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.cashier_movements.OrderByDescending(x => x.cm_movement_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.cm_movement_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("cashier_movements_save")]
    public IActionResult cashier_movements_save(List<cashier_movement> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<cashier_movement, bool>> predicate = c => c.cm_movement_id == item.cm_movement_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"cashier_movements_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("cashier_movements_grouped_by_hour")]
    public IActionResult cashier_movements_grouped_by_hour()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.cashier_movements_grouped_by_hours.OrderByDescending(x => x.cm_unique_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.cm_unique_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("cashier_movements_grouped_by_hour_save")]
    public IActionResult cashier_movements_grouped_by_hour_save(List<cashier_movements_grouped_by_hour> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<cashier_movements_grouped_by_hour, bool>> predicate = c => 
                c.CM_DATE == item.CM_DATE &&
                c.CM_TYPE == item.CM_TYPE &&
                c.CM_SUB_TYPE == item.CM_SUB_TYPE &&
                c.CM_CURRENCY_ISO_CODE == item.CM_CURRENCY_ISO_CODE &&
                c.CM_CAGE_CURRENCY_TYPE == item.CM_CAGE_CURRENCY_TYPE &&
                c.CM_CURRENCY_DENOMINATION == item.CM_CURRENCY_DENOMINATION
                ;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"cashier_movements_grouped_by_hour_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("cashier_sessions")]
    public IActionResult cashier_sessions()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.cashier_sessions.OrderByDescending(x => x.cs_session_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.cs_session_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("cashier_sessions_save")]
    public IActionResult cashier_sessions_save(List<cashier_session> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<cashier_session, bool>> predicate = c =>
                c.cs_session_id == item.cs_session_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"cashier_sessions_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("cashier_sessions_by_currency")]
    public IActionResult cashier_sessions_by_currency()
    {
        int total;
        try
        {
            total = _context.cashier_sessions_by_currencies.Count();
            return Ok(total);

        } catch(Exception)
        {
            return Ok(0);
        }

    }
    [HttpPost]
    [Route("cashier_sessions_by_currency_save")]
    public IActionResult cashier_sessions_by_currency_save(List<cashier_sessions_by_currency> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<cashier_sessions_by_currency, bool>> predicate = c =>
                    c.csc_session_id == item.csc_session_id &&
                    c.csc_iso_code == item.csc_iso_code &&
                    c.csc_type == item.csc_type;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"cashier_sessions_by_currency_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("cashier_vouchers")]
    public IActionResult cashier_vouchers()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.cashier_vouchers.OrderByDescending(x => x.cv_voucher_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.cv_voucher_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("cashier_vouchers_save")]
    public IActionResult cashier_vouchers_save(List<cashier_voucher> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<cashier_voucher, bool>> predicate = c =>
                c.cv_voucher_id == item.cv_voucher_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"cashier_vouchers_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("customer_bucket")]
    public IActionResult customer_bucket()
    {
        int total;
        try
        {
            total = _context.customer_buckets.Count();
            return Ok(total);

        } catch(Exception)
        {
            return Ok(0);
        }

    }
    [HttpPost]
    [Route("customer_bucket_save")]
    public IActionResult customer_bucket_save(List<customer_bucket> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<customer_bucket, bool>> predicate = c =>
                    c.cbu_customer_id == item.cbu_customer_id &&
                    c.cbu_bucket_id == item.cbu_bucket_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"customer_bucket_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("customer_record_details")]
    public IActionResult customer_record_details()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.customer_record_details.OrderByDescending(x => x.curd_detail_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.curd_detail_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("customer_record_details_save")]
    public IActionResult customer_record_details_save(List<customer_record_detail> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<customer_record_detail, bool>> predicate = c =>
                c.curd_detail_id == item.curd_detail_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"customer_record_details_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("customer_record_details_history")]
    public IActionResult customer_record_details_history()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.customer_record_details_histories.OrderByDescending(x => x.curdh_detail_history_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.curdh_detail_history_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("customer_record_details_history_save")]
    public IActionResult customer_record_details_history_save(List<customer_record_details_history> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<customer_record_details_history, bool>> predicate = c =>
                c.curdh_detail_history_id == item.curdh_detail_history_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"customer_record_details_history_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("customer_records")]
    public IActionResult customer_records()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.customer_records.OrderByDescending(x => x.cur_record_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.cur_record_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("customer_records_save")]
    public IActionResult customer_records_save(List<customer_record> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<customer_record, bool>> predicate = c =>
                c.cur_record_id == item.cur_record_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"customer_records_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("customer_records_history")]
    public IActionResult customer_records_history()
    {
        long lastId = 0;
        try
        {
            var lastElement = _context.customer_records_histories.OrderByDescending(x => x.curh_record_history_id).FirstOrDefault();
            lastId = lastElement == null ? 0 : lastElement.curh_record_history_id;

        } catch(Exception)
        {
            lastId = 0;
        }

        return Ok(lastId);
    }
    [HttpPost]
    [Route("customer_records_history_save")]
    public IActionResult customer_records_history_save(List<customer_records_history> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<customer_records_history, bool>> predicate = c =>
                c.curh_record_history_id == item.curh_record_history_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"customer_records_history_save method -> " + ex.Message);
            return Ok(false);
        }
    }
    [HttpGet]
    [Route("customers")]
    public IActionResult customers()
    {
        int total;
        try
        {
            total = _context.customers.Count();
            return Ok(total);

        } catch(Exception)
        {
            return Ok(0);
        }

    }
    [HttpPost]
    [Route("customers_save")]
    public IActionResult customers_save(List<customer> data)
    {
        try
        {
            foreach(var item in data)
            {
                Expression<Func<customer, bool>> predicate = c =>
                    c.cus_customer_id == item.cus_customer_id;
                _context.InsertIfNotExists(item, predicate);
                _context.SaveChanges();
            }
            return Ok(true);
        } catch(Exception ex)
        {
            _logger.LogError($"customers_save method -> " + ex.Message);
            return Ok(false);
        }
    }
	[HttpGet]
	[Route("daily_meters")]
	public IActionResult daily_meters()
	{
		DateTime? last_created;
		try
		{
			var lastElement = _context.daily_meters.OrderByDescending(x => x.Date).FirstOrDefault();
			last_created = lastElement?.Date;
			return Ok(last_created);

		} catch(Exception)
		{
			return Ok(null);
		}
	}
	[HttpPost]
	[Route("daily_meters_save")]
	public IActionResult daily_meters_save(List<daily_meter> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<daily_meter, bool>> predicate = c => c.Site == item.Site && c.Term == item.Term && c.Date == item.Date;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"daily_meters_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("draw_tickets")]
	public IActionResult draw_tickets()
	{
		long lastId = 0;
		try
		{
			var lastElement = _context.draw_tickets.OrderByDescending(x => x.dt_id).FirstOrDefault();
			lastId = lastElement == null ? 0 : lastElement.dt_id;

		} catch(Exception)
		{
			lastId = 0;
		}

		return Ok(lastId);
	}
	[HttpPost]
	[Route("draw_tickets_save")]
	public IActionResult draw_tickets_save(List<draw_ticket> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<draw_ticket, bool>> predicate = c =>
				c.dt_id == item.dt_id;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"draw_tickets_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("draws")]
	public IActionResult draws()
	{
		long lastId = 0;
		try
		{
			var lastElement = _context.draws.OrderByDescending(x => x.dr_id).FirstOrDefault();
			lastId = lastElement == null ? 0 : lastElement.dr_id;

		} catch(Exception)
		{
			lastId = 0;
		}

		return Ok(lastId);
	}
	[HttpPost]
	[Route("draws_save")]
	public IActionResult draws_save(List<draw> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<draw, bool>> predicate = c =>
				c.dr_id == item.dr_id;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"draws_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("event_history")]
	public IActionResult event_history()
	{
		long lastId = 0;
		try
		{
			var lastElement = _context.event_histories.OrderByDescending(x => x.eh_event_id).FirstOrDefault();
			lastId = lastElement == null ? 0 : lastElement.eh_event_id;

		} catch(Exception)
		{
			lastId = 0;
		}

		return Ok(lastId);
	}
	[HttpPost]
	[Route("event_history_save")]
	public IActionResult event_history_save(List<event_history> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<event_history, bool>> predicate = c =>
				c.eh_datetime == item.eh_datetime &&
                c.eh_terminal_id == item.eh_terminal_id &&
                c.eh_event_id == item.eh_event_id;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"event_history_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("game_meters")]
	public IActionResult game_meters()
	{
		int total;
		try
		{
			total = _context.game_meters.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("game_meters_save")]
	public IActionResult game_meters_save(List<game_meter> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<game_meter, bool>> predicate = c =>
					c.gm_terminal_id == item.gm_terminal_id &&
                    c.gm_game_base_name == item.gm_game_base_name
                    ;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"game_meters_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("games")]
	public IActionResult games()
	{
		int total;
		try
		{
			total = _context.games.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("games_save")]
	public IActionResult games_save(List<game> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<game, bool>> predicate = c =>
					c.gm_game_id== item.gm_game_id
					;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"games_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("general_params")]
	public IActionResult general_params()
	{
		int total;
		try
		{
			total = _context.general_params.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("general_params_save")]
	public IActionResult general_params_save(List<general_param> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<general_param, bool>> predicate = c =>
					c.gp_group_key == item.gp_group_key &&
                    c.gp_subject_key == item.gp_subject_key
					;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"general_params_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("gift_instances")]
	public IActionResult gift_instances()
	{
		long lastId = 0;
		try
		{
			var lastElement = _context.gift_instances.OrderByDescending(x => x.gin_gift_instance_id).FirstOrDefault();
			lastId = lastElement == null ? 0 : lastElement.gin_gift_instance_id;

		} catch(Exception)
		{
			lastId = 0;
		}

		return Ok(lastId);
	}
	[HttpPost]
	[Route("gift_instances_save")]
	public IActionResult gift_instances_save(List<gift_instance> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<gift_instance, bool>> predicate = c =>
				c.gin_gift_instance_id == item.gin_gift_instance_id;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"gift_instances_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("gui_audit")]
	public IActionResult gui_audit()
	{
		DateTime? last_created;
		try
		{
			var lastElement = _context.gui_audits.OrderByDescending(x => x.ga_datetime).FirstOrDefault();
			last_created = lastElement?.ga_datetime;
			return Ok(last_created);

		} catch(Exception)
		{
			return Ok(null);
		}
	}
	[HttpPost]
	[Route("gui_audit_save")]
	public IActionResult gui_audit_save(List<gui_audit> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<gui_audit, bool>> predicate = c => c.ga_audit_id == item.ga_audit_id && c.ga_item_order == item.ga_item_order;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"gui_audit_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("gui_profile_forms")]
	public IActionResult gui_profile_forms()
	{
		int total;
		try
		{
			total = _context.gui_profile_forms.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("gui_profile_forms_save")]
	public IActionResult gui_profile_forms_save(List<gui_profile_form> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<gui_profile_form, bool>> predicate = c =>
					c.gpf_profile_id == item.gpf_profile_id &&
					c.gpf_gui_id == item.gpf_gui_id &&
                    c.gpf_form_id == item.gpf_form_id;
					;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"gui_profile_forms_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("gui_users")]
	public IActionResult gui_users()
	{
		int total;
		try
		{
			total = _context.gui_users.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("gui_users_save")]
	public IActionResult gui_users_save(List<gui_user> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<gui_user, bool>> predicate = c =>
					c.gu_user_id == item.gu_user_id
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"gui_users_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("h_m2d_smh")]
	public IActionResult h_m2d_smh()
	{
		int total;
		try
		{
			total = _context.h_m2d_smhs.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("h_m2d_smh_save")]
	public IActionResult h_m2d_smh_save(List<h_m2d_smh> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<h_m2d_smh, bool>> predicate = c =>
					c.x2d_date == item.x2d_date &&
                    c.x2d_weekday == item.x2d_weekday &&
                    c.x2d_id == item.x2d_id &&
                    c.x2d_meter_id == item.x2d_meter_id &&
                    c.x2d_meter_item == item.x2d_meter_item
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"h_m2d_smh_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("h_m2d_tmh")]
	public IActionResult h_m2d_tmh()
	{
		int total;
		try
		{
			total = _context.h_m2d_tmhs.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("h_m2d_tmh_save")]
	public IActionResult h_m2d_tmh_save(List<h_m2d_tmh> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<h_m2d_tmh, bool>> predicate = c =>
					c.x2d_date == item.x2d_date &&
					c.x2d_weekday == item.x2d_weekday &&
					c.x2d_id == item.x2d_id &&
					c.x2d_meter_id == item.x2d_meter_id &&
					c.x2d_meter_item == item.x2d_meter_item
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"h_m2d_tmh_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("h_pvh")]
	public IActionResult h_pvh()
	{
		int total;
		try
		{
			total = _context.h_pvhs.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("h_pvh_save")]
	public IActionResult h_pvh_save(List<h_pvh> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<h_pvh, bool>> predicate = c =>
					c.pvh_account_id == item.pvh_account_id&&
					c.pvh_date == item.pvh_date
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"h_pvh_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("h_t2d_smh")]
	public IActionResult h_t2d_smh()
	{
		int total;
		try
		{
			total = _context.h_t2d_smhs.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("h_t2d_smh_save")]
	public IActionResult h_t2d_smh_save(List<h_t2d_smh> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<h_t2d_smh, bool>> predicate = c =>
					c.x2d_date == item.x2d_date &&
					c.x2d_weekday == item.x2d_weekday &&
                    c.x2d_id == item.x2d_id &&
                    c.x2d_meter_id == item.x2d_meter_id &&
                    c.x2d_meter_item == item.x2d_meter_item
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"h_t2d_smh_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("h_t2d_tmh")]
	public IActionResult h_t2d_tmh()
	{
		int total;
		try
		{
			total = _context.h_t2d_tmhs.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("h_t2d_tmh_save")]
	public IActionResult h_t2d_tmh_save(List<h_t2d_tmh> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<h_t2d_tmh, bool>> predicate = c =>
					c.x2d_date == item.x2d_date &&
					c.x2d_weekday == item.x2d_weekday &&
					c.x2d_id == item.x2d_id &&
					c.x2d_meter_id == item.x2d_meter_id &&
					c.x2d_meter_item == item.x2d_meter_item
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"h_t2d_tmh_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("h_w2d_smh")]
	public IActionResult h_w2d_smh()
	{
		int total;
		try
		{
			total = _context.h_w2d_smhs.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("h_w2d_smh_save")]
	public IActionResult h_w2d_smh_save(List<h_w2d_smh> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<h_w2d_smh, bool>> predicate = c =>
					c.x2d_date == item.x2d_date &&
					c.x2d_weekday == item.x2d_weekday &&
					c.x2d_id == item.x2d_id &&
					c.x2d_meter_id == item.x2d_meter_id &&
					c.x2d_meter_item == item.x2d_meter_item
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"h_w2d_smh_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("h_w2d_tmh")]
	public IActionResult h_w2d_tmh()
	{
		int total;
		try
		{
			total = _context.h_w2d_tmhs.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("h_w2d_tmh_save")]
	public IActionResult h_w2d_tmh_save(List<h_w2d_tmh> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<h_w2d_tmh, bool>> predicate = c =>
					c.x2d_date == item.x2d_date &&
					c.x2d_weekday == item.x2d_weekday &&
					c.x2d_id == item.x2d_id &&
					c.x2d_meter_id == item.x2d_meter_id &&
					c.x2d_meter_item == item.x2d_meter_item
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"h_w2d_tmh_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("h_x2d_control")]
	public IActionResult h_x2d_control()
	{
		int total;
		try
		{
			total = _context.h_x2d_controls.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("h_x2d_control_save")]
	public IActionResult h_x2d_control_save(List<h_x2d_control> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<h_x2d_control, bool>> predicate = c =>
					c.x2d_date == item.x2d_date &&
					c.x2d_meter_type == item.x2d_meter_type 
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"h_x2d_control_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("h_y2d_smh")]
	public IActionResult h_y2d_smh()
	{
		int total;
		try
		{
			total = _context.h_y2d_smhs.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("h_y2d_smh_save")]
	public IActionResult h_y2d_smh_save(List<h_y2d_smh> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<h_y2d_smh, bool>> predicate = c =>
					c.x2d_date == item.x2d_date &&
					c.x2d_weekday == item.x2d_weekday &&
					c.x2d_id == item.x2d_id &&
					c.x2d_meter_id == item.x2d_meter_id &&
					c.x2d_meter_item == item.x2d_meter_item
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"h_y2d_smh_save method -> " + ex.Message);
			return Ok(false);
		}
	}
	[HttpGet]
	[Route("h_y2d_tmh")]
	public IActionResult h_y2d_tmh()
	{
		int total;
		try
		{
			total = _context.h_y2d_tmhs.Count();
			return Ok(total);

		} catch(Exception)
		{
			return Ok(0);
		}

	}
	[HttpPost]
	[Route("h_y2d_tmh_save")]
	public IActionResult h_y2d_tmh_save(List<h_y2d_tmh> data)
	{
		try
		{
			foreach(var item in data)
			{
				Expression<Func<h_y2d_tmh, bool>> predicate = c =>
					c.x2d_date == item.x2d_date &&
					c.x2d_weekday == item.x2d_weekday &&
					c.x2d_id == item.x2d_id &&
					c.x2d_meter_id == item.x2d_meter_id &&
					c.x2d_meter_item == item.x2d_meter_item
				;
				_context.InsertIfNotExists(item, predicate);
				_context.SaveChanges();
			}
			return Ok(true);
		} catch(Exception ex)
		{
			_logger.LogError($"h_y2d_tmh_save method -> " + ex.Message);
			return Ok(false);
		}
	}
}
