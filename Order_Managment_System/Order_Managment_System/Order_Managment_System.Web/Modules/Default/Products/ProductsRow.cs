
namespace Order_Managment_System.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), Module("Default"), TableName("[dbo].[Products]")]
    [DisplayName("Products"), InstanceName("Products")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript]
    public sealed class ProductsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Product Id"), Column("product_id"), Identity, LookupInclude]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Product Name"), Column("product_name"), Size(255), NotNull, QuickSearch, LookupInclude]
        public String ProductName
        {
            get { return Fields.ProductName[this]; }
            set { Fields.ProductName[this] = value; }
        }

        [DisplayName("Description"), Column("description"), Size(255), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Price"), Column("price"), NotNull]
        public Int32? Price
        {
            get { return Fields.Price[this]; }
            set { Fields.Price[this] = value; }
        }

        [DisplayName("Stock Quantity"), Column("stock_quantity"), NotNull]
        public Int32? StockQuantity
        {
            get { return Fields.StockQuantity[this]; }
            set { Fields.StockQuantity[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ProductId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ProductName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProductsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ProductId;
            public StringField ProductName;
            public StringField Description;
            public Int32Field Price;
            public Int32Field StockQuantity;
        }
    }
}
