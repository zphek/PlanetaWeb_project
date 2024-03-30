
namespace Order_Managment_System.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Orders")]
    [BasedOnRow(typeof(Entities.OrdersRow), CheckNames = true)]
    public class OrdersForm
    {
        [Category("Order")]
        public Int32 CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public Int32 TotalAmount { get; set; }
        public String Status { get; set; }

        [Category("Order details")]
        [OrdersDetailsEditor]

        public List<Entities.OrdersDetailsRow> DetailList { get; set; }
    }
}