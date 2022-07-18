using DDD.Domain.Entities.Orders;

namespace DDD.Domain.Contracts.Orders;

public interface IGetAllOrderQuery
{
    List<OrderDto> Execute();
}