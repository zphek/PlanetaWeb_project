namespace Order_Managment_System.Default {
    export interface OrdersDetailsForm {
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
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(OrdersDetailsForm, [
                    'ProductId', w0,
                    'Quantity', w1,
                    'UnitPrice', w1,
                    'Subtotal', w1
                ]);
            }
        }
    }
}

