
namespace Order_Managment_System.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Orders")]
    [BasedOnRow(typeof(Entities.OrdersRow), CheckNames = true)]
    public class OrdersColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 OrderId { get; set; }
        public String CustomerFirstName { get; set; }
        public DateTime OrderDate { get; set; }
        public Int32 TotalAmount { get; set; }
        [EditLink]
        public String Status { get; set; }
    }
}