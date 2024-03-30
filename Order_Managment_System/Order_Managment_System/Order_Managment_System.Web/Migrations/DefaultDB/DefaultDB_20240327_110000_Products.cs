using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace Order_Managment_System.Migrations.DefaultDB
{
    [Migration(20240327110000)]
    public class DefaultDB_20240327_110000_Products : Migration
    {
        public override void Up()
        {
            Create.Table("Products")
                  .WithColumn("product_id").AsInt32().Identity().PrimaryKey().NotNullable()
                  .WithColumn("product_name").AsString().Unique()
                  .WithColumn("description").AsString()
                  .WithColumn("price").AsInt32().Unique()
                  .WithColumn("stock_quantity").AsInt32();
        }

        public override void Down()
        {
            Delete.Table("Products");
        }
    }
}