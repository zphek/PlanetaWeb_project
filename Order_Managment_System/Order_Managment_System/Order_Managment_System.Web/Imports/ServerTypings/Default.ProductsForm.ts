namespace Order_Managment_System.Default {
    export interface ProductsForm {
        ProductName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Price: Serenity.IntegerEditor;
        StockQuantity: Serenity.IntegerEditor;
    }

    export class ProductsForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Products';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductsForm.init)  {
                ProductsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(ProductsForm, [
                    'ProductName', w0,
                    'Description', w0,
                    'Price', w1,
                    'StockQuantity', w1
                ]);
            }
        }
    }
}

