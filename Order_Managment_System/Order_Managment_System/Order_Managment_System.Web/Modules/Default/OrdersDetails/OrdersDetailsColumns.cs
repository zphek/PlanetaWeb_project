
namespace Order_Managment_System.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.OrdersDetails")]
    [BasedOnRow(typeof(Entities.OrdersDetailsRow), CheckNames = true)]
    public class OrdersDetailsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public string OrderId { get; set; }
        public String ProductProductName { get; set; }
        public Int32 Quantity { get; set; }
        public Int32 Subtotal { get; set; }

        public Int32 UnitPrice { get; set; }
    }
}