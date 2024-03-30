namespace Order_Managment_System.Default {
    export interface OrdersDetailsForm {
        OrderId: Serenity.IntegerEditor;
        ProductId: Serenity.LookupEditor;
        Quantity: Serenity.IntegerEditor;
        UnitPrice: Serenity.IntegerEditor;
        Subtotal: Serenity.IntegerEditor;
    }

    export class OrdersDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.OrdersDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrdersDetailsForm.init)  {
                OrdersDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(OrdersDetailsForm, [
                    'OrderId', w0,
                    'ProductId', w1,
                    'Quantity', w0,
                    'UnitPrice', w0,
                    'Subtotal', w0
                ]);
            }
        }
    }
}

