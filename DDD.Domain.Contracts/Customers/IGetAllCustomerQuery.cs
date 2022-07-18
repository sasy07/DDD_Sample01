using DDD.Domain.Entities.Customers;

namespace DDD.Domain.Contracts.Customers;

public interface IGetAllCustomerQuery
{
    List<Customer> Execute();
}