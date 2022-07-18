using DDD.Data.EF.Common;
using DDD.Domain.Contracts.Salesmen;
using DDD.Domain.Entities.Salesmen;

namespace DDD.Data.EF.Salesmen;

public class SalesmanRepository:BaseEfRepository,ISalesmanRepository
{
    public SalesmanRepository(DataContext context) : base(context)
    {
    }

    public List<Salesman> Salesmen()
        => _context.Salesmen.ToList();
}