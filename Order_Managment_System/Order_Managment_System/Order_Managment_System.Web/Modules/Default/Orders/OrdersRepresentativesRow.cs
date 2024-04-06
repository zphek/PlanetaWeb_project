using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Order_Managment_System.Modules.Default.Orders
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Default"), Module("Default"), TableName("OrdersRepresentatives")]
    [DisplayName("OrdersRepresentatives"), InstanceName("OrdersRepresentatives")]
    [ReadPermission(PermissionKeys.Orders.View)]
    public sealed class OrdersRepresentativesRow : Row, IIdRow
    {
        [DisplayName("Representative Id"), Column("RepresentativeID"), Identity]
        public Int32? RepresentativeId
        {
            get { return Fields.RepresentativeId[this]; }
            set { Fields.RepresentativeId[this] = value; }
        }

        [DisplayName("Order Id"), Column("order_id"), NotNull]
        public Int32? OrderId
        {
            get { return Fields.OrderId[this]; }
            set { Fields.OrderId[this] = value; }
        }

        [DisplayName("Product Id"), Column("product_id"), NotNull]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.RepresentativeId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public OrdersRepresentativesRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field RepresentativeId;
            public Int32Field OrderId;
            public Int32Field ProductId;
        }
    }
}