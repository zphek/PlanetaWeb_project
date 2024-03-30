using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Order_Managment_System.Default
{
    public partial class OrdersDetailsEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Order_Managment_System.Default.OrdersDetailsEditor";

        public OrdersDetailsEditorAttribute()
            : base(Key)
        {
        }
    }
}

