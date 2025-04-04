using Employee.Management.Domain.ValueObjects;
using MongoDB.Bson.Serialization.Attributes;

namespace Employee.Management.Domain.Entities;

public class Company(Guid id, string name, string cnpj, IEnumerable<Address> address)
{
    [BsonId]
    public Guid Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string CNPJ { get; set; } = cnpj;
    public IEnumerable<Address> Address { get; set; } = address;
}