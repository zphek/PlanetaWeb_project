namespace Order_Managment_System.Default {
    export interface CustomersForm {
        FirstName: Serenity.StringEditor;
        LastName: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        PhoneNumber: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        City: Serenity.StringEditor;
        UserId: Serenity.LookupEditor;
    }

    export class CustomersForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Customers';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CustomersForm.init)  {
                CustomersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;

                Q.initFormType(CustomersForm, [
                    'FirstName', w0,
                    'LastName', w0,
                    'Email', w0,
                    'PhoneNumber', w0,
                    'Address', w0,
                    'City', w0,
                    'UserId', w1
                ]);
            }
        }
    }
}

