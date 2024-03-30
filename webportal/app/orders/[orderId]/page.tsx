"use client"

import axios from "axios";
import Link from "next/link";
import { useParams } from "next/navigation"
import { useEffect, useState } from "react";

interface userData{
    customer_id: number,
    first_name: string,
    last_name: string,
    email: string,
    phone_number: string
}

interface detail{
    product_id: number,
    price: number,
    product_name: string,
    quantity: number,
    subtotal: number
}

export default function OrderDetails(){
    const {orderId}:any = useParams();
    const [details, setDetails] = useState<detail[]>([]);
    const [order, setOrder] = useState({
        order_id: 0,
        order_date: '"',
        total_amount: 0
    });
    const [show, setShow] = useState(true);

    const user:userData = JSON.parse(localStorage.getItem("user_data") || "");

    function handleClick(){
        setShow(false);
    }

    useEffect(()=>{
        if(!show){
            setTimeout(()=>{
                print();
            }, 1000)
            
            setTimeout(()=>{
                setShow(true);
            }, 2000)
        }
    }, [show])
    
    useEffect(()=>{
        axios({
            url: "/api/details",
            method: "post",
            data: { user_email: user.email, order_id: orderId }
        })
        .then(({data})=>{
            setDetails(data);
            console.log(data);
        })
        .catch(err=>{
            console.log(err)
        })

        axios({
            url: "/api/orders",
            method: "post",
            data: { order_id: orderId }
        })
        .then(({data})=>{
            setOrder(data);
            console.log(data);
        })
        .catch(err=>{
            console.log(err)
        })
    }, [])

    return(
        <div className="min-h-screen w-screen bg-slate-100 flex justify-center">
            <div className="w-[100%] lg:w-[60%] px-10 py-5">
                <Link href="/orders" className={"font-bold text-blue-500 text-lg " + (!show && "hidden")}>
                    {"<-"} BACK HOME
                </Link>

                <h2 className={"mt-5 font-extrabold text-3xl flex flex-col border-b-2 border-slate-500 py-5 " + (!show && "hidden")}>My products</h2>

                <div className={"flex flex-col gap-y-2 " + (show && "hidden")}>
                    <h2 className="w-[100%]"><strong>FULL NAME:</strong> {user.first_name + " " + user.last_name}</h2>
                    <h2 className="w-[100%]"><strong>EMAIL:</strong> {user.email}</h2>
                    <h2 className="w-[100%]"><strong>ID ORDER:</strong> {order.order_id}</h2>
                    <h2 className="w-[100%]"><strong>DATE:</strong> {order.order_date}</h2>
                    <h2 className="w-[100%]"><strong>TOTAL AMOUNT:</strong> {order.order_date}</h2>
                </div>

                <button className={"px-4 py-2 bg-red-500 rounded-xl text-white mt-2 " + (!show && "hidden")} onClick={handleClick}>PRINT INVOICE</button>

                <table className="min-w-full divide-y divide-gray-200">
                    <thead>
                        <tr>
                            <th scope="col" className="px-6 py-3 bg-gray-50 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">ID</th>
                            <th scope="col" className="px-6 py-3 bg-gray-50 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">Product Name</th>
                            <th scope="col" className="px-6 py-3 bg-gray-50 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">Quantity</th>
                            <th scope="col" className="px-6 py-3 bg-gray-50 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">Price</th>
                            <th scope="col" className="px-6 py-3 bg-gray-50 text-left text-xs font-medium text-gray-500 uppercase tracking-wider">Subtotal</th>
                        </tr>
                    </thead>
                    <tbody className="bg-white divide-y divide-gray-200">
                        {details.length == 0 ? <tr><td className="px-6 py-4 whitespace-nowrap" colSpan={5}>THERE'S NO PRODUCTS.</td></tr>:
                        details.map(det=> <tr>
                            <td className="px-6 py-4 whitespace-nowrap">{det.product_id}</td>
                            <td className="px-6 py-4 whitespace-nowrap">{det.product_name}</td>
                            <td className="px-6 py-4 whitespace-nowrap">{det.quantity}</td>
                            <td className="px-6 py-4 whitespace-nowrap">${det.price}</td>
                            <td className="px-6 py-4 whitespace-nowrap">${det.subtotal}</td>
                        </tr>)}
                    </tbody>
                </table>

            </div>
        </div>
    )
}