namespace Order_Managment_System.Default {
    export interface CustomersRow {
        CustomerId?: number;
        FirstName?: string;
        LastName?: string;
        Email?: string;
        PhoneNumber?: string;
        Address?: string;
        City?: string;
        UserId?: number;
    }

    export namespace CustomersRow {
        export const idProperty = 'CustomerId';
        export const nameProperty = 'Email';
        export const localTextPrefix = 'Default.Customers';
        export const lookupKey = 'Default.Customers';

        export function getLookup(): Q.Lookup<CustomersRow> {
            return Q.getLookup<CustomersRow>('Default.Customers');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            CustomerId = "CustomerId",
            FirstName = "FirstName",
            LastName = "LastName",
            Email = "Email",
            PhoneNumber = "PhoneNumber",
            Address = "Address",
            City = "City",
            UserId = "UserId"
        }
    }
}

