using DDD.Data.EF.Common;
using DDD.Domain.Contracts.Orders;
using DDD.Domain.Entities.Orders;

namespace DDD.Data.EF.Orders;

public class OrderRepository : BaseEfRepository, IOrderRepository
{
    public OrderRepository(DataContext context) : base(context)
    {
    }

    public List<OrderDto> Orders()
        => _context.Orders
            .Select(o => new OrderDto
            {
                OrderId = o.OrderId,
                Price = o.Price,
                Quantity = o.Quantity,
                CustomerName = $"{o.Customer.FirstName} {o.Customer.LastName}",
                GoodName = o.Good.Name,
                SalesmanName = $"{o.Salesman.FirstName} {o.Salesman.LastName}",
                TotalPrice = o.TotalPrice
            }).ToList();

    public Order Find(int id)
        => _context.Orders.Find(id);
}