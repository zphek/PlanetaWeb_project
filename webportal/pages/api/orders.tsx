import sequelize from "@/helpers/db_helper";
import { NextApiRequest, NextApiResponse } from "next";

export default async function handler(req: NextApiRequest, res: NextApiResponse){
    const {order_id} = req.body;

    if(order_id){
        const response:any = await sequelize.query(`SELECT * FROM dbo.Orders WHERE order_id = ${order_id}`);
        console.log(response);
        if(response[0]){
            return res.json(response[0][0]);
        }
    }
    
    const {user_email} = req.body;

    if(!user_email){
        return res.json({
            success: false,
            message: "Email field missing."
        })
    }

    const response:any = await sequelize.query(`SELECT * FROM dbo.Orders INNER JOIN Customers ON Orders.customer_id = Customers.customer_id WHERE Customers.Email = '${user_email}'`);
    console.log(response);
    if(response[0]){
        if(!Array.isArray(response[0])){
            return res.json([response[0][0]]);    
        }
        return res.json(response[0]);
    }

    return res.json({
        success: false,
        message: "Given E-mail doesn't has orders."
    });
}