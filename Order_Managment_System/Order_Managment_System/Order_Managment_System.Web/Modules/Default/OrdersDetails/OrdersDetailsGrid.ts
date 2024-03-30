
namespace Order_Managment_System.Default {

    @Serenity.Decorators.registerClass()
    export class OrdersDetailsGrid extends Serenity.EntityGrid<OrdersDetailsRow, any> {
        protected getColumnsKey() { return 'Default.OrdersDetails'; }
        protected getDialogType() { return OrdersDetailsDialog; }
        protected getIdProperty() { return OrdersDetailsRow.idProperty; }
        protected getInsertPermission() { return OrdersDetailsRow.insertPermission; }
        protected getLocalTextPrefix() { return OrdersDetailsRow.localTextPrefix; }
        protected getService() { return OrdersDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}