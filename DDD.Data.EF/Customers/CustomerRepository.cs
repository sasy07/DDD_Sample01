using DDD.Data.EF.Common;
using DDD.Domain.Contracts.Customers;
using DDD.Domain.Entities.Customers;

namespace DDD.Data.EF.Customers;

public class CustomerRepository:BaseEfRepository, ICustomerRepository
{
    public CustomerRepository(DataContext context) : base(context)
    {
    }

    public List<Customer> Customers()
        => _context.Customers.ToList();
}