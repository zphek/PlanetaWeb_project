
namespace Order_Managment_System.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Orders_details]")]
    [DisplayName("Orders Details"), InstanceName("Orders Details")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class OrdersDetailsRow : Row, IIdRow
    {
        [DisplayName("Order Details Id"), Column("order_details_id"), Identity]
        public Int32? OrderDetailsId
        {
            get { return Fields.OrderDetailsId[this]; }
            set { Fields.OrderDetailsId[this] = value; }
        }

        [DisplayName("Order Id"), Insertable(false), Column("order_id"), ForeignKey("[dbo].[Orders]", "order_id"), LeftJoin("jOrder"), TextualField("OrderStatus"), Updatable(false)]
        public Int32? OrderId
        {
            get { return Fields.OrderId[this]; }
            set { Fields.OrderId[this] = value; }
        }

        [DisplayName("Product"), Column("product_id"), NotNull, ForeignKey("[dbo].[Products]", "product_id"), LeftJoin("jProduct"), TextualField("Product ProductName")]
        [LookupEditor(typeof(ProductsRow))]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Quantity"), Column("quantity"), NotNull]
        public Int32? Quantity
        {
            get { return Fields.Quantity[this]; }
            set { Fields.Quantity[this] = value; }
        }

        [DisplayName("UnitPrice"), Column("UnitPrice"), NotNull]
        public Int32? UnitPrice
        {
            get { return Fields.UnitPrice[this]; }
            set { Fields.UnitPrice[this] = value; }
        }

        [DisplayName("Subtotal"), Column("subtotal"), NotNull]
        public Int32? Subtotal
        {
            get { return Fields.Subtotal[this]; }
            set { Fields.Subtotal[this] = value; }
        }

        [DisplayName("Order Customer Id"), Expression("jOrder.[customer_id]")]
        public Int32? OrderCustomerId
        {
            get { return Fields.OrderCustomerId[this]; }
            set { Fields.OrderCustomerId[this] = value; }
        }

        [DisplayName("Order Order Date"), Expression("jOrder.[order_date]")]
        public DateTime? OrderOrderDate
        {
            get { return Fields.OrderOrderDate[this]; }
            set { Fields.OrderOrderDate[this] = value; }
        }

        [DisplayName("Order Total Amount"), Expression("jOrder.[total_amount]")]
        public Int32? OrderTotalAmount
        {
            get { return Fields.OrderTotalAmount[this]; }
            set { Fields.OrderTotalAmount[this] = value; }
        }

        [DisplayName("Order Status"), Expression("jOrder.[status]")]
        public String OrderStatus
        {
            get { return Fields.OrderStatus[this]; }
            set { Fields.OrderStatus[this] = value; }
        }

        [DisplayName("Product Product Name"), Expression("jProduct.[product_name]")]
        public String ProductProductName
        {
            get { return Fields.ProductProductName[this]; }
            set { Fields.ProductProductName[this] = value; }
        }

        [DisplayName("Product Description"), Expression("jProduct.[description]")]
        public String ProductDescription
        {
            get { return Fields.ProductDescription[this]; }
            set { Fields.ProductDescription[this] = value; }
        }

        [DisplayName("Product Price"), Expression("jProduct.[price]")]
        public Int32? ProductPrice
        {
            get { return Fields.ProductPrice[this]; }
            set { Fields.ProductPrice[this] = value; }
        }

        [DisplayName("Product Stock Quantity"), Expression("jProduct.[stock_quantity]")]
        public Int32? ProductStockQuantity
        {
            get { return Fields.ProductStockQuantity[this]; }
            set { Fields.ProductStockQuantity[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.OrderDetailsId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OrdersDetailsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field OrderDetailsId;
            public Int32Field OrderId;
            public Int32Field ProductId;
            public Int32Field Quantity;
            public Int32Field Subtotal;
            public Int32Field UnitPrice;

            public Int32Field OrderCustomerId;
            public DateTimeField OrderOrderDate;
            public Int32Field OrderTotalAmount;
            public StringField OrderStatus;

            public StringField ProductProductName;
            public StringField ProductDescription;
            public Int32Field ProductPrice;
            public Int32Field ProductStockQuantity;
        }
    }
}
