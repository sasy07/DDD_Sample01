using DDD.Domain.Entities.Customers;
using DDD.Domain.Entities.Goods;
using DDD.Domain.Entities.Salesmen;

namespace DDD.Domain.Entities.Orders;

public class Order
{
    private int _quantity;
    private int _price;
    private int _totalPrice;


    public int OrderId { get; set; }
    public Good Good { get; set; }
    public Salesman Salesman { get; set; }
    public Customer Customer { get; set; }

    public int Quantity
    {
        get => _quantity;
        set
        {
            _quantity = value;
            UpdateTotalPrice();
        }
    }
    public int Price
    {
        get => _price;
        set
        {
            _price = value;
            UpdateTotalPrice();
        }
    }
    public int TotalPrice
    {
        get => _totalPrice;
        set => _totalPrice = value;
    }

    private void UpdateTotalPrice()
    {
        _totalPrice = Quantity * Price;
    }
}