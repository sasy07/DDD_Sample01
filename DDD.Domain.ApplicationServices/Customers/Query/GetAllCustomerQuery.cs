using DDD.Domain.Contracts.Customers;
using DDD.Domain.Entities.Customers;

namespace DDD.Domain.ApplicationServices.Customers.Query;

public class GetAllCustomerQuery:IGetAllCustomerQuery
{
    private readonly ICustomerRepository _customerRepository;

    public List<Customer> Execute()
        => _customerRepository.Customers();
}