
namespace Order_Managment_System.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.OrdersDetails")]
    [BasedOnRow(typeof(Entities.OrdersDetailsRow), CheckNames = true)]
    public class OrdersDetailsForm
    {
        /*public Int32 OrderId { get; set; }
        */public Int32 ProductId { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 UnitPrice { get; set; }
        public Int32 Subtotal { get; set; }
    }
}