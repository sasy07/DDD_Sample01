using DDD.Domain.Entities.Customers;

namespace DDD.Domain.Contracts.Customers;

public interface ICustomerRepository
{
    List<Customer> Customers();
}