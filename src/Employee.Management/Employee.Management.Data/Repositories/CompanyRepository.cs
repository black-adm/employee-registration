using System.Linq.Expressions;
using Employee.Management.Domain.Entities;
using Employee.Management.Domain.Interfaces;
using MongoDB.Driver;

namespace Employee.Management.Data.Repositories;

public class CompanyRepository(IMongoDatabase mongoDatabase)
    : BaseRepository<Company>(mongoDatabase, "companies"), ICompanyRepository
{
    public Task AddOneSync(Company entity)
    {
        throw new NotImplementedException();
    }

    public Task ReplaceOneAsync(Expression<Func<Company, bool>> filterExpression, Company entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Expression<Func<Company, bool>> filterExpression)
    {
        throw new NotImplementedException();
    }
}