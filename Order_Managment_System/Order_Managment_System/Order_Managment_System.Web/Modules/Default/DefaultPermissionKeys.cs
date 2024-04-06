using Serenity.Extensibility;
using System.ComponentModel;

namespace Order_Managment_System.Modules.Default
{
    [NestedPermissionKeys]
    [DisplayName("Default")]
    public class PermissionKeys
    {
        [DisplayName("Orders")]
        public class Orders
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Default:Orders:Delete";
            [Description("Read"), ImplicitPermission(View)]
            public const string View = "Default:Orders:View";
        }

        [Description("[General]")]
        public const string General = "Default:General";
    }
}