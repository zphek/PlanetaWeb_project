namespace Order_Managment_System.Default {
    export interface OrdersRow {
        OrderId?: number;
        CustomerId?: number;
        OrderDate?: string;
        TotalAmount?: number;
        Status?: string;
        CustomerFirstName?: string;
        CustomerLastName?: string;
        CustomerEmail?: string;
        CustomerPhoneNumber?: string;
        CustomerAddress?: string;
        CustomerCity?: string;
        DetailList?: OrdersDetailsRow[];
    }

    export namespace OrdersRow {
        export const idProperty = 'OrderId';
        export const nameProperty = 'Status';
        export const localTextPrefix = 'Default.Orders';
        export const lookupKey = 'Default.Orders';

        export function getLookup(): Q.Lookup<OrdersRow> {
            return Q.getLookup<OrdersRow>('Default.Orders');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderId = "OrderId",
            CustomerId = "CustomerId",
            OrderDate = "OrderDate",
            TotalAmount = "TotalAmount",
            Status = "Status",
            CustomerFirstName = "CustomerFirstName",
            CustomerLastName = "CustomerLastName",
            CustomerEmail = "CustomerEmail",
            CustomerPhoneNumber = "CustomerPhoneNumber",
            CustomerAddress = "CustomerAddress",
            CustomerCity = "CustomerCity",
            DetailList = "DetailList"
        }
    }
}

