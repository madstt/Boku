using System.Web.Mvc;
using Boku.DomainLogicLayer.AccountModels;
using Ninject;

namespace Boku.Web.Controllers
{
    public class BaseController : Controller
    {
        [Inject]
        public User LoggedInUser { get; set; }  
    }
}
