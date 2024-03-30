using Serenity.Navigation;
using MyPages = Order_Managment_System.Default.Pages;

[assembly: NavigationLink(int.MaxValue, "Default/Customers", typeof(MyPages.CustomersController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Orders", typeof(MyPages.OrdersController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Orders Details", typeof(MyPages.OrdersDetailsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Default/Products", typeof(MyPages.ProductsController), icon: null)]