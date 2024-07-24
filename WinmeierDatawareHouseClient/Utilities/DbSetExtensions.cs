using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace WinmeierDatawareHouseClient.Utilities;

public static class DbSetExtensions
{
	public static void InsertIfNotExists<TEntity>(this DbContext context, TEntity entity, Expression<Func<TEntity, bool>> predicate)
	   where TEntity : class
	{
		// Verificar si ya existe un registro que cumpla con el predicado
		if(!context.Set<TEntity>().Any(predicate))
		{
			context.Set<TEntity>().Add(entity);
		}
	}
}
