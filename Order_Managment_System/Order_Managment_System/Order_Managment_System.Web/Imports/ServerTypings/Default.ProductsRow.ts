namespace Order_Managment_System.Default {
    export interface ProductsRow {
        ProductId?: number;
        ProductName?: string;
        Description?: string;
        Price?: number;
        StockQuantity?: number;
    }

    export namespace ProductsRow {
        export const idProperty = 'ProductId';
        export const nameProperty = 'ProductName';
        export const localTextPrefix = 'Default.Products';
        export const lookupKey = 'Default.Products';

        export function getLookup(): Q.Lookup<ProductsRow> {
            return Q.getLookup<ProductsRow>('Default.Products');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            ProductId = "ProductId",
            ProductName = "ProductName",
            Description = "Description",
            Price = "Price",
            StockQuantity = "StockQuantity"
        }
    }
}

