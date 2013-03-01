using System;
using System.Web.Security;

namespace Boku.Web.Security
{
    /// <summary>
    /// Default implementation of System.Web.Security.Membership abstraction.
    /// </summary>
    public class MembershipService : IMembershipService
    {
        public MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
        {
            return Membership.CreateUser(username, password, email, passwordQuestion, passwordAnswer, isApproved,
                                  providerUserKey, out status);
        }

        public MembershipUser GetUser(string username, bool userIsOnline)
        {
            return Membership.GetUser(username, userIsOnline);
        }

        public bool ValidateUser(string username, string password)
        {
            return Membership.ValidateUser(username, password);
        }
    }
}