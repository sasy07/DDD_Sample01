using DDD.Data.EF.Common;
using DDD.Data.EF.Customers;
using DDD.Data.EF.Goods;
using DDD.Data.EF.Orders;
using DDD.Data.EF.Salesmen;
using DDD.Domain.ApplicationServices.Customers.Query;
using DDD.Domain.ApplicationServices.Goods.Query;
using DDD.Domain.ApplicationServices.Orders.Query;
using DDD.Domain.ApplicationServices.Salesmen.Query;
using DDD.Domain.Contracts.Customers;
using DDD.Domain.Contracts.Goods;
using DDD.Domain.Contracts.Orders;
using DDD.Domain.Contracts.Salesmen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region IoC

builder.Services.AddScoped<DataContext>();

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IGoodRepository, GoodRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ISalesmanRepository, SalesmanRepository>();

builder.Services.AddScoped<IGetAllCustomerQuery, GetAllCustomerQuery>();
builder.Services.AddScoped<IGetAllGoodQuery, GetAllGoodQuery>();
builder.Services.AddScoped<IGetAllSalesmanQuery, GetAllSalesmanQuery>();
builder.Services.AddScoped<IGetAllOrderQuery, GetAllOrderQuery>();
builder.Services.AddScoped<IFindOrderQuery, FindOrderQuery>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();