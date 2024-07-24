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
}
