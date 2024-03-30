
namespace Order_Managment_System.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Products")]
    [BasedOnRow(typeof(Entities.ProductsRow), CheckNames = true)]
    public class ProductsForm
    {
        public String ProductName { get; set; }
        public String Description { get; set; }
        public Int32 Price { get; set; }
        public Int32 StockQuantity { get; set; }
    }
}