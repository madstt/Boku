using System.Collections.Generic;
using System.Web.Mvc;

namespace Boku.Web.Controllers
{
    public class RecipesController : BaseController
    {
        //
        // GET: /Recipes/

        public ActionResult Index()
        {
            List<string> types = new List<string>();
            types.Add("okse");
            //ViewData.Model = LoggedInUser;
            ViewData["user"] = LoggedInUser;
            return View();
        }

    }
}
