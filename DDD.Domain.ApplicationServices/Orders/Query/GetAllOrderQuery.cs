using DDD.Domain.Contracts.Orders;
using DDD.Domain.Entities.Orders;

namespace DDD.Domain.ApplicationServices.Orders.Query;

public class GetAllOrderQuery:IGetAllOrderQuery
{
    private readonly IOrderRepository _orderRepository;

    public List<OrderDto> Execute()
        => _orderRepository.Orders();
}