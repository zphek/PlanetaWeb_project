/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace Order_Managment_System.Default {

    @Serenity.Decorators.registerClass()
    export class OrdersDetailsDialog extends Serenity.EntityDialog<OrdersDetailsRow, any> {
        protected getFormKey() { return OrdersDetailsForm.formKey; }
        protected getIdProperty() { return OrdersDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return OrdersDetailsRow.localTextPrefix; }
        protected getService() { return OrdersDetailsService.baseUrl; }
        protected getDeletePermission() { return OrdersDetailsRow.deletePermission; }
        protected getInsertPermission() { return OrdersDetailsRow.insertPermission; }
        protected getUpdatePermission() { return OrdersDetailsRow.updatePermission; }

        protected form: OrdersDetailsForm;
        protected form2: OrdersForm;

        constructor() {
            super();

            this.form = new OrdersDetailsForm(this.idPrefix);

            this.form.ProductId.changeSelect2(e => {
                var productId = Q.toId(this.form.ProductId.value);

                if (productId != null) {
                    this.form.Quantity.value = this.form.Quantity.value || 1;
                    this.form.UnitPrice.value = ProductsRow.getLookup().itemById[productId].Price;
                    this.form.Subtotal.value = (this.form.Quantity.value * this.form.UnitPrice.value);
                }
            })

            this.form.Quantity.change(e => {
                var productId = Q.toId(this.form.ProductId.value);

                if (productId != null) {
                    this.form.Subtotal.value = this.form.Quantity.value * ProductsRow.getLookup().itemById[productId].Price}
            })
        }
    }
}