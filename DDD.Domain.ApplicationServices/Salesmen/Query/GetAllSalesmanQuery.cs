using DDD.Domain.Contracts.Salesmen;
using DDD.Domain.Entities.Salesmen;

namespace DDD.Domain.ApplicationServices.Salesmen.Query;

public class GetAllSalesmanQuery:IGetAllSalesmanQuery
{
    private readonly ISalesmanRepository _salesmanRepository;

    public List<Salesman> Execute()
        => _salesmanRepository.Salesmen();
}