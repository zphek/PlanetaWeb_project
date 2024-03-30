using Serenity.Services;

namespace Order_Managment_System.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}