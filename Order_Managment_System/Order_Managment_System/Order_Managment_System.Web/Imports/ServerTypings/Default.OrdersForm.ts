namespace Order_Managment_System.Default {
    export interface OrdersForm {
        CustomerId: Serenity.LookupEditor;
        OrderDate: Serenity.DateEditor;
        TotalAmount: Serenity.IntegerEditor;
        Status: Serenity.StringEditor;
        DetailList: OrdersDetailsEditor;
    }

    export class OrdersForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Orders';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrdersForm.init)  {
                OrdersForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.StringEditor;
                var w4 = OrdersDetailsEditor;

                Q.initFormType(OrdersForm, [
                    'CustomerId', w0,
                    'OrderDate', w1,
                    'TotalAmount', w2,
                    'Status', w3,
                    'DetailList', w4
                ]);
            }
        }
    }
}

