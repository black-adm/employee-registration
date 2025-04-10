using System.Linq.Expressions;

namespace Employee.Management.Domain.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task AddOneSync(TEntity entity);
    Task ReplaceOneAsync(Expression<Func<TEntity, bool>> filterExpression, TEntity entity);
    Task DeleteAsync(Expression<Func<TEntity, bool>> filterExpression);
}