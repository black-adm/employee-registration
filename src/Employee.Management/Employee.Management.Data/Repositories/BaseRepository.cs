using System.Linq.Expressions;
using Employee.Management.Domain.Interfaces;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace Employee.Management.Data.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly IMongoCollection<TEntity> _collection;

    public BaseRepository(IMongoDatabase mongoDb, string collectionName)
    {
        MapClass();
        _collection = mongoDb.GetCollection<TEntity>(collectionName);
    }

    public async Task AddOneSync(TEntity entity)
    {
        await _collection.InsertOneAsync(entity);
    }

    public async Task ReplaceOneAsync(Expression<Func<TEntity, bool>> filterExpression, TEntity entity)
    {
        await _collection.ReplaceOneAsync(filterExpression, entity);
    }

    public async Task DeleteAsync(Expression<Func<TEntity, bool>> filterExpression)
    {
        await _collection.DeleteOneAsync(filterExpression);
    }
    
    private static void MapClass()
    {
        if (!BsonClassMap.IsClassMapRegistered(typeof(TEntity)))
        {
            BsonClassMap.TryRegisterClassMap<TEntity>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
            });
        }
    }
}