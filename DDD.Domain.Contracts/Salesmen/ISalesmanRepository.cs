using DDD.Domain.Entities.Salesmen;

namespace DDD.Domain.Contracts.Salesmen;

public interface ISalesmanRepository
{
    List<Salesman> Salesmen();
}