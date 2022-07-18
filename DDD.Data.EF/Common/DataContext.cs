using DDD.Domain.Entities.Customers;
using DDD.Domain.Entities.Goods;
using DDD.Domain.Entities.Orders;
using DDD.Domain.Entities.Salesmen;
using Microsoft.EntityFrameworkCore;

namespace DDD.Data.EF.Common;

public class DataContext:DbContext
{
  #region DbSets
  
  public DbSet<Salesman> Salesmen { get; set; }
  public DbSet<Order> Orders { get; set; }
  public DbSet<Good> Goods { get; set; }
  public DbSet<Customer> Customers { get; set; }

  #endregion
  
  
}