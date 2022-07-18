using DDD.Domain.Contracts.Orders;
using DDD.Domain.Entities.Orders;

namespace DDD.Domain.ApplicationServices.Orders.Query;

public class FindOrderQuery:IFindOrderQuery
{
    private readonly IOrderRepository _orderRepository;

    public Order Execute(int id)
        => _orderRepository.Find(id);
}