"use client";
import sequelize from "@/helpers/db_helper";
import axios from "axios";
import { RedirectType, redirect } from "next/navigation";
import { Router } from "next/router";
import { stringify } from "querystring";
import { FormEvent } from "react";

export default function Home() {

  function handleSubmit(event: FormEvent<HTMLFormElement>){
    event.preventDefault();
    const formData = new FormData(event.currentTarget); // Obtener los datos del formulario
    const user_email = formData.get("user_email");

    axios({
      url: "/api/customers",
      method: "POST",
      data: {user_email}
    })
    .then(({data}:any)=>{
      console.log(data)
      localStorage.setItem("user_data", JSON.stringify(data))
      window.location.href = "/orders";
    })
    .catch(err=>{
      console.log(err)
    })
  }
  
  return (
    <div className="bg-blue-100 min-h-screen w-screen flex flex-col items-center justify-center">
        <h2 className="text-5xl font-extrabold align-center">USER ORDER TRACKER</h2>
        <h3 className="mt-2">Type your email, to see your orders.</h3>

        <form onSubmit={handleSubmit}  className="flex flex-col w-[60%] lg:w-[40%]">
          <input type="text" name="user_email" id="" className="mt-5 outline-none bg-transparent border-b-2 border-blue-800 py-2 px-3 w-[100%]" placeholder="type here"/>  
          <button className="bg-blue-500 py-3 text-white rounded-lg mt-3">SEE ORDERS</button>
        </form>    
    </div>
  );
}
