
    namespace Order_Managment_System.Default.Entities
    {
        using Order_Managment_System.Modules.Default;
        using Serenity;
        using Serenity.ComponentModel;
        using Serenity.Data;
        using Serenity.Data.Mapping;
        using System;
        using System.Collections.Generic;
        using System.ComponentModel;
        using System.IO;

        [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Orders]")]
        [DisplayName("Orders"), InstanceName("Orders")]
        /*[ReadPermission("Administration:General")]*/
        [ModifyPermission("Administration:General")]
        [ReadPermission(PermissionKeys.Orders.View)]
        [LookupScript]
        public sealed class OrdersRow : Row, IIdRow, INameRow
        {
            [DisplayName("Order Id"), Column("order_id"), Identity]
            public Int32? OrderId
            {
                get { return Fields.OrderId[this]; }
                set { Fields.OrderId[this] = value; }
            }

            [DisplayName("Customer"), Column("customer_id"), NotNull, ForeignKey("[dbo].[Customers]", "customer_id"), LeftJoin("jCustomer"), TextualField("CustomerFirstName")]
            [LookupEditor(typeof(CustomersRow))]
            public Int32? CustomerId
            {
                get { return Fields.CustomerId[this]; }
                set { Fields.CustomerId[this] = value; }
            }

            [DisplayName("Order Date"), Column("order_date"), NotNull]
            [DefaultValue("now")]
            public DateTime? OrderDate
            {
                get { return Fields.OrderDate[this]; }
                set { Fields.OrderDate[this] = value; }
            }

            [DisplayName("Total Amount"), Column("total_amount"), NotNull]
            public Int32? TotalAmount
            {
                get { return Fields.TotalAmount[this]; }
                set { Fields.TotalAmount[this] = value; }
            }

            [DisplayName("Status"), Column("status"), Size(255), NotNull, QuickSearch]
            public String Status
            {
                get { return Fields.Status[this]; }
                set { Fields.Status[this] = value; }
            }

            [DisplayName("Customer First Name"), Expression("jCustomer.[first_name]")]
            public String CustomerFirstName
            {
                get { return Fields.CustomerFirstName[this]; }
                set { Fields.CustomerFirstName[this] = value; }
            }

            [DisplayName("Customer Last Name"), Expression("jCustomer.[last_name]")]
            public String CustomerLastName
            {
                get { return Fields.CustomerLastName[this]; }
                set { Fields.CustomerLastName[this] = value; }
            }

            [DisplayName("Customer Email"), Expression("jCustomer.[email]")]
            public String CustomerEmail
            {
                get { return Fields.CustomerEmail[this]; }
                set { Fields.CustomerEmail[this] = value; }
            }

            [DisplayName("Customer Phone Number"), Expression("jCustomer.[phone_number]")]
            public String CustomerPhoneNumber
            {
                get { return Fields.CustomerPhoneNumber[this]; }
                set { Fields.CustomerPhoneNumber[this] = value; }
            }

            [DisplayName("Customer Address"), Expression("jCustomer.[address]")]
            public String CustomerAddress
            {
                get { return Fields.CustomerAddress[this]; }
                set { Fields.CustomerAddress[this] = value; }
            }

            [DisplayName("Customer City"), Expression("jCustomer.[city]")]
            public String CustomerCity
            {
                get { return Fields.CustomerCity[this]; }
                set { Fields.CustomerCity[this] = value; }
            }

            [DisplayName("Details"), MasterDetailRelation(foreignKey: "order_id"), NotMapped]
            public List<OrdersDetailsRow> DetailList
            {
                get { return Fields.DetailList[this]; }
                set { Fields.DetailList[this] = value; }
            }

            [DisplayName("UserId"), Expression("jCustomer.[user_id]"), NotMapped]
            public Int32? UserId
            {
                get { return Fields.UserId[this]; }
                set { Fields.UserId[this] = value; }
            }

            IIdField IIdRow.IdField
            {
                get { return Fields.OrderId; }
            }

            StringField INameRow.NameField
            {
                get { return Fields.Status; }
            }

            public static readonly RowFields Fields = new RowFields().Init();

            public OrdersRow()
                : base(Fields)
            {
            }

            public class RowFields : RowFieldsBase
            {
                public Int32Field OrderId;
                public Int32Field CustomerId;
                public DateTimeField OrderDate;
                public Int32Field TotalAmount;
                public StringField Status;

                public StringField CustomerFirstName;
                public StringField CustomerLastName;
                public StringField CustomerEmail;
                public StringField CustomerPhoneNumber;
                public StringField CustomerAddress;
                public StringField CustomerCity;
                public Int32Field UserId;
                public RowListField<OrdersDetailsRow> DetailList;
            }
        }
    }
