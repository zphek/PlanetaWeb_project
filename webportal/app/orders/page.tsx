'use client';

import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import axios from "axios";
import Link from "next/link";
import { useEffect, useState } from "react";

interface order{
    order_id: number, 
    order_date: string,
    total_amount: number,
    status: string,
    address: string
}

interface userData{
    customer_id: number,
    first_name: string,
    last_name: string,
    email: string,
    phone_number: string
}

function getStatus(status:string){
    switch(status){
        case "Entregado":
            return [100, "blue"]
            break;

        case "En camino":
            return [50, "red"]
            break;
        
        default: 
            return [10, "slate"]
            break;
    }
}

export function Order({data}:any){
    const {order_id, order_date, total_amount, status, address}:order = data;
    const [percentaje, color]:any = getStatus(status);
    return(
        <div className="flex py-5 px-5 bg-slate-100 items-center justify-between gap-x-10 mt-2">
            <section className="flex flex-col">
                <h2 className="font-bold">ORDER DATE: {order_date}</h2>
                <h2 className="font-bold">TOTAL AMOUNT: {total_amount}</h2>
            </section>

            <section className="flex flex-col flex-grow px-16 gap-y-2 items-center">
                <progress max={100} value={percentaje} className={`w-[100%] [&::-webkit-progress-bar]:rounded-lg [&::-webkit-progress-value]:rounded-lg   [&::-webkit-progress-bar]:bg-slate-300 [&::-webkit-progress-value]:bg-${color}-500 [&::-moz-progress-bar]:bg-${color}-500`}/>
                <h2 className="font-extrabold">{status.toUpperCase()}</h2>
            </section>

            <Link href={`/orders/${order_id}`} className=" py-2 px-5 bg-blue-800 text-white rounded-lg">
                SEE PRODUCTS
            </Link>
        </div>
    );
}

export default function Orders(){
    const [ords, setOrders] = useState<order[]>([]);
    const [filtered, setFiltered] = useState<order[]>([]);

    function getFiltered(){

    }
    
    const user:userData = JSON.parse(localStorage.getItem("user_data") || "");

    useEffect(()=>{
        console.log(user);
        axios({
            url: "/api/orders",
            method: "post",
            data: { user_email: user.email }
        })
        .then(({data})=>{
            console.log(data)
            setOrders(data);
        })
        .catch((err)=>{
            console.log(err);
        })
    }, [])

    return (<div className="bg-slate-200 min-h-screen w-screen flex justify-center">
        <div className="w-[100%] lg:w-[60%] py-10 px-10 lg:px-5">
            <div className="flex items-center justify-between">
                <h3 className="text-xl">Welcome {user.first_name + " " + user.last_name}</h3>

                <Link href={"/"} className="bg-red-500 shadow-xl hover:shadow-sm py-2 px-10 text-white rounded-xl transition-all" onClick={()=>{ localStorage.clear() }}>
                    EXIT
                </Link>
            </div>
            <h2 className="font-extrabold text-4xl mt-2 border-b-2 border-slate-800 py-3">MY ORDERS</h2>

            <div className="flex w-[100%] mt-2">
                <FontAwesomeIcon icon={"search"}/>
                <input type="text" name="" id="" placeholder="Filter by..." className="flex-grow px-4 py-2 rounded-lg outline-none"/>
                <select className="px-2">
                    <option value="" defaultChecked>Order Date</option>
                    <option value="" defaultChecked>Order ID</option>
                    <option value="" defaultChecked>Status</option>
                </select>
            </div>

            <div className="orders mt-5 max-h-screen overflow-scroll">
                {ords.length == 0 ? <h2>
                    FOR THE MOMENT THERE'S NO ORDERS.
                </h2> : ords.map((ord)=><Order data={ord} key={ord.order_id}/>)}
            </div>
        </div>
    </div>)
}