
namespace Order_Managment_System.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/OrdersDetails"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.OrdersDetailsRow))]
    public class OrdersDetailsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/OrdersDetails/OrdersDetailsIndex.cshtml");
        }
    }
}