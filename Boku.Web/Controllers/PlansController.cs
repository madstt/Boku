using System.Web.Mvc;

namespace Boku.Web.Controllers
{
    public class PlansController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}