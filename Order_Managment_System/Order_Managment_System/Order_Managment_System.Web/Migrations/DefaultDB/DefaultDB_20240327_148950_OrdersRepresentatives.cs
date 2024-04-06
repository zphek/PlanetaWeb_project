using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace Order_Managment_System.Migrations.DefaultDB
{
    [Migration(20240327140050)]
    public class DefaultDB_20240327_148950_OrdersRepresentatives : Migration
    {
        public override void Up()
        {
            Create.Table("OrdersRepresentatives")
                   .WithColumn("RepresentativeID").AsInt32().Identity().PrimaryKey()
                   .WithColumn("order_id").AsInt32()
                   .WithColumn("product_id").AsInt32();
        }

        public override void Down()
        {
            Delete.FromTable("OrdersRepresentatives");
        }
    }
}