using System.Web.Security;

namespace Boku.Web.Security
{
    /// <summary>
    /// Abstraction of System.Web.Security.Membership
    /// </summary>
    public interface IMembershipService
    {
        MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status);
        MembershipUser GetUser(string username, bool userIsOnline);
        bool ValidateUser(string username, string password);
    }
}