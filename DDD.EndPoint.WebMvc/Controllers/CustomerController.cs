using DDD.Domain.Contracts.Customers;
using Microsoft.AspNetCore.Mvc;

namespace DDD.EndPoint.WebMvc.Controllers;

public class CustomerController : Controller
{
    private readonly IGetAllCustomerQuery _getAllCustomerQuery;

    public CustomerController(IGetAllCustomerQuery getAllCustomerQuery)
    {
        _getAllCustomerQuery = getAllCustomerQuery;
    }

    public IActionResult Index()
        => View(_getAllCustomerQuery.Execute());
}