using DDD.Domain.Entities.Orders;

namespace DDD.Domain.Contracts.Orders;

public interface IFindOrderQuery
{
    Order Execute(int id);
}