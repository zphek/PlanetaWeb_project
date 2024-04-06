using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace Order_Managment_System.Migrations.DefaultDB
{
    [Migration(20240327138000)]
    public class DefaultDB_20240327_138000_Orders_Details : Migration
    {
        public override void Up()
        {
            Create.Table("Orders_details")
                  .WithColumn("order_details_id").AsInt32().Identity().NotNullable().PrimaryKey()
                  .WithColumn("order_id").AsInt32().Nullable()
                  .WithColumn("product_id").AsInt32().NotNullable()
                  .WithColumn("UnitPrice").AsInt32().NotNullable()
                  .WithColumn("quantity").AsInt32()
                  .WithColumn("subtotal").AsInt32();

            Create.ForeignKey()
                  .FromTable("Orders_details").ForeignColumn("order_id")
                  .ToTable("Orders").PrimaryColumn("order_id");

            Create.ForeignKey()
                  .FromTable("Orders_details").ForeignColumn("product_id")
                  .ToTable("Products").PrimaryColumn("product_id");

            Create.ForeignKey()
                  .FromTable("Orders").ForeignColumn("customer_id")
                  .ToTable("Customers").PrimaryColumn("customer_id");
        }

        public override void Down()
        {
            Delete.FromTable("Orders_details");
        }
    }
}