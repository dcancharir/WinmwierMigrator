using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WinmeierDataWarehouseClient.Context;
using WinmeierDataWarehouseClient.Models;

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
		var lastElement = _context.account_documents.OrderByDescending(x => x.ad_created).FirstOrDefault();
		return Ok(lastElement);
	}
	[HttpPost]
	[Route("account_documents_save")]
	public IActionResult account_documents_save(List<account_document> items)
	{
		_context.account_documents.AddRange(items);
		_context.SaveChanges();
		return Ok();
	}
	[HttpGet]
	[Route("account_movements")]
	public IActionResult account_movements()
	{
		long lastId = 0;
		try
		{
			var lastElement = _context.account_movements.OrderByDescending(x => x.am_movement_id).FirstOrDefault();
			if(lastElement != null)
			{
				lastId = lastElement.am_movement_id;
			}

		} catch(Exception)
		{
			lastId=0;
		}
		
		return Ok(lastId);
	}
	[HttpPost]
	[Route("account_movements_save")]
	public IActionResult account_movements_save(List<account_movement> items)
	{
		try
		{
			foreach(var item in items)
			{
				_context.account_movements.Add(item);
				_context.SaveChanges();
			}
			return Ok();
		} catch(Exception ex)
		{
			_logger.LogError($"account_movements_save method -> " +ex.Message);
			return BadRequest();
		}
	
	}
	[HttpGet]
	[Route("account_operations")]
	public IActionResult account_operations()
	{
		var lastElement = _context.account_operations.OrderByDescending(x => x.ao_operation_id).FirstOrDefault();
		return Ok(lastElement);
	}
	[HttpPost]
	[Route("account_operations_save")]
	public IActionResult account_operations_save(List<account_operation> items)
	{
		_context.account_operations.AddRange(items);
		_context.SaveChanges();
		return Ok();
	}
}
