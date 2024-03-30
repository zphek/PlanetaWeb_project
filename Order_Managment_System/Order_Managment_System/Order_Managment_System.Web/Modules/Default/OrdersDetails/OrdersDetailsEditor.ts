/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace Order_Managment_System.Default {

    @Serenity.Decorators.registerClass()
    export class OrdersDetailsEditor extends Common.GridEditorBase<OrdersDetailsRow> {
        protected getColumnsKey() { return "Default.OrdersDetails"; }
        protected getDialogType() { return OrdersDetailsDialog; }
        protected getLocalTextPrefix() { return OrdersDetailsRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        validateEntity(row, id) {
            row.ProductId = Q.toId(row.ProductId);

            var sameProduct = Q.tryFirst(this.view.getItems(), x => x.ProductId === row.ProductId);
            if (sameProduct && this.id(sameProduct) !== id) {
                Q.alert('This product is already in order details!');
                return false;
            }

            row.ProductName = ProductsRow.getLookup().itemById[row.ProductID].ProductName;
            row.Subtotal = (row.Quantity || 0) * (row.UnitPrice || 0);
            return true;
        }
    }
}