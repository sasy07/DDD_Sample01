using DDD.Domain.Entities.Orders;

namespace DDD.Domain.Contracts.Orders;

public interface IOrderRepository
{
    List<OrderDto> Orders();
    Order Find(int id);
}