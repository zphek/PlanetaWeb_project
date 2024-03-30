
namespace Order_Managment_System.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Orders"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.OrdersRow))]
    public class OrdersController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Orders/OrdersIndex.cshtml");
        }
    }
}