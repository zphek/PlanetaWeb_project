import sequelize from "@/helpers/db_helper";
import { NextApiRequest, NextApiResponse } from "next";

export default async function handler(req:NextApiRequest, res:NextApiResponse){
    const {user_email, order_id} = req.body;

    if(!user_email || !order_id){
        return res.json({
            success: false,
            message: !user_email ? "Email field missing." : "Order_id field missing."
        })
    }

    const response:any = await sequelize.query(`SELECT Products.product_id, Products.price, Products.product_name, Products.description, Products.stock_quantity, Orders_details.quantity, Orders_details.subtotal FROM dbo.Orders_details INNER JOIN Products ON products.product_id = Orders_details.product_id INNER JOIN Orders ON Orders.order_id = Orders_details.order_id INNER JOIN Customers ON Customers.customer_id = Orders.customer_id WHERE Customers.email = '${user_email}' and Orders.order_id = ${order_id};`);
    
    console.log(response);
    
    if(response[0]){
        if(!Array.isArray(response[0])){
            return res.json([response[0][0]]);    
        }
        return res.json(response[0]);
    }

    return res.json({
        success: false,
        message: "His order doesn't has products."
    });
}