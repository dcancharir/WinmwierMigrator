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

}
