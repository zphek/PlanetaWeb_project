using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace Order_Managment_System.Migrations.DefaultDB
{
    [Migration(20240327135000)]
    public class DefaultDB_20240327_135000_Orders : Migration
    {
        public override void Up()
        {
            Create.Table("Orders")
                  .WithColumn("order_id").AsInt32().Identity().PrimaryKey().NotNullable()
                  .WithColumn("customer_id").AsInt32()
                  .WithColumn("order_date").AsDate().WithDefaultValue(DateTime.Now)
                  .WithColumn("total_amount").AsInt32()
                  .WithColumn("status").AsString();
        }

        public override void Down()
        {
            Delete.FromTable("Orders");
        }
    }
}