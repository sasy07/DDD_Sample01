using DDD.Domain.Entities.Salesmen;

namespace DDD.Domain.Contracts.Salesmen;

public interface IGetAllSalesmanQuery
{
    List<Salesman> Execute();
}