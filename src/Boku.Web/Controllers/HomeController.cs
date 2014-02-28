using System.Web.Mvc;
using Boku.DomainLogicLayer;
using Boku.DomainLogicLayer.AccountModels;

namespace Boku.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

        public ActionResult Login(User loginModel)
        {
            ViewBag.UserName = loginModel.UserName;
            ViewBag.Email = loginModel.Email;
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
