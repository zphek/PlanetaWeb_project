namespace Order_Managment_System.Modules.Default.Orders {
    export interface OrdersRepresentativesRow {
        RepresentativeId?: number;
        OrderId?: number;
        ProductId?: number;
    }

    export namespace OrdersRepresentativesRow {
        export const idProperty = 'RepresentativeId';
        export const localTextPrefix = 'Default.OrdersRepresentatives';
        export const deletePermission = 'Default:Orders:View';
        export const insertPermission = 'Default:Orders:View';
        export const readPermission = 'Default:Orders:View';
        export const updatePermission = 'Default:Orders:View';

        export declare const enum Fields {
            RepresentativeId = "RepresentativeId",
            OrderId = "OrderId",
            ProductId = "ProductId"
        }
    }
}

