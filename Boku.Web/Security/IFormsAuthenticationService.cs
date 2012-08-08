namespace Boku.Web.Security
{
    /// <summary>
    /// Abstraction of System.Web.Security.FormsAuthenticationService.
    /// </summary>
    public interface IFormsAuthenticationService
    {
        void SetAuthCookie(string userName, bool createPersistentCookie);
    }
}