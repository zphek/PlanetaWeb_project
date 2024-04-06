using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentMigrator;

namespace Order_Managment_System.Migrations.DefaultDB
{
    [Migration(20240327120000)]
    public class DefaultDB_20240327_120000_Customers : Migration
    {
        public override void Up()
        {
            Create.Table("Customers")
                  .WithColumn("customer_id").AsInt32().Identity().PrimaryKey().NotNullable()
                  .WithColumn("first_name").AsString()
                  .WithColumn("last_name").AsString()
                  .WithColumn("email").AsString().Unique()
                  .WithColumn("phone_number").AsString()
                  .WithColumn("address").AsString()
                  .WithColumn("city").AsString()
                  .WithColumn("user_id").AsInt32().Unique();

            Create.ForeignKey()
                  .FromTable("Customers").ForeignColumn("user_id")
                  .ToTable("Users").PrimaryColumn("UserId");
        }

        public override void Down()
        {
            Delete.FromTable("Customers");
        }
    }
}