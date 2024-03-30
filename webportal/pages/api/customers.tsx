import sequelize from "@/helpers/db_helper";
import { NextApiRequest, NextApiResponse } from "next";

export default async function handler(req: NextApiRequest, res: NextApiResponse){
    const {user_email} = await req.body;

    if(!user_email){
        return res.json({
            success: false,
            message: "Email field missing."
        })
    }

    const response:any = await sequelize.query(`SELECT * FROM dbo.Customers WHERE email = '${user_email}'`);
    console.log(response);

    if(response[1] == 1){
        return res.json(response[0][0]);
    }

    return res.json({
        success: false,
        message: "Given E-mail doesn't has orders."
    });
}