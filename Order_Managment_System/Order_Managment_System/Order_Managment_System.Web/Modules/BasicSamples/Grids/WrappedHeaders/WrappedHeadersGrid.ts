/// <reference path="../../../Northwind/Order/OrderGrid.ts" />

namespace Order_Managment_System.BasicSamples {

    @Serenity.Decorators.registerClass()
    export class WrappedHeadersGrid extends Northwind.OrderGrid {

        constructor(container: JQuery) {
            super(container);
        }
    }
}