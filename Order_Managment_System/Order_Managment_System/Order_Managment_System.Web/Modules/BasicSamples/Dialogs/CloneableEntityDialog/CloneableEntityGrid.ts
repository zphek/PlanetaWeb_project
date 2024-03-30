/// <reference path="../../../Northwind/Product/ProductGrid.ts" />

namespace Order_Managment_System.BasicSamples {

    /**
     * Subclass of ProductGrid to override dialog type to CloneableEntityDialog
     */
    @Serenity.Decorators.registerClass()
    export class CloneableEntityGrid extends Northwind.ProductGrid {

        protected getDialogType() { return CloneableEntityDialog; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}