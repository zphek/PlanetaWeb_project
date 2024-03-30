namespace Order_Managment_System.Default {
    export interface OrdersDetailsRow {
        OrderDetailsId?: number;
        OrderId?: number;
        ProductId?: number;
        Quantity?: number;
        Subtotal?: number;
        OrderCustomerId?: number;
        OrderOrderDate?: string;
        OrderTotalAmount?: number;
        OrderStatus?: string;
        ProductProductName?: string;
        ProductDescription?: string;
        ProductPrice?: number;
        ProductStockQuantity?: number;
    }

    export namespace OrdersDetailsRow {
        export const idProperty = 'OrderDetailsId';
        export const localTextPrefix = 'Default.OrdersDetails';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderDetailsId = "OrderDetailsId",
            OrderId = "OrderId",
            ProductId = "ProductId",
            Quantity = "Quantity",
            Subtotal = "Subtotal",
            OrderCustomerId = "OrderCustomerId",
            OrderOrderDate = "OrderOrderDate",
            OrderTotalAmount = "OrderTotalAmount",
            OrderStatus = "OrderStatus",
            ProductProductName = "ProductProductName",
            ProductDescription = "ProductDescription",
            ProductPrice = "ProductPrice",
            ProductStockQuantity = "ProductStockQuantity"
        }
    }
}

