using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Order_Managment_System.Modules.Default.Orders
{
    public enum OrderStatus
    {
        Pendiente,
        Procesado,
        Enviado,
        Entregado,
        Cancelado
    }
}