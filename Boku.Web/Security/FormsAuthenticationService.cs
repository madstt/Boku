using System.Web.Security;

namespace Boku.Web.Security
{
    /// <summary>
    /// Default implementation of System.Web.Security.FormsAuthenticationService abstraction.
    /// </summary>
    class FormsAuthenticationService : IFormsAuthenticationService
    {
        public void SetAuthCookie(string userName, bool createPersistentCookie)
        {
            FormsAuthentication.SetAuthCookie(userName, createPersistentCookie);
        }
    }
}