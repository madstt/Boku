using Boku.Web.Security;
using Ninject.Modules;

namespace Boku.Web.NinjectModules
{
    public class AccountModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMembershipService>().To<MembershipService>();
            Bind<IFormsAuthenticationService>().To<FormsAuthenticationService>();
        }
    }
}