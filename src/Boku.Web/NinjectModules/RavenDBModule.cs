using Griffin.MvcContrib.Providers.Membership;
using Griffin.MvcContrib.Providers.Membership.PasswordStrategies;
using Griffin.MvcContrib.RavenDb.Providers;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;
using Ninject.Web.Common;
using Raven.Client;
using Raven.Client.Document;

namespace Boku.Web.NinjectModules
{
    public class RavenDBModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDocumentStore>()
                .ToMethod(InitDocStore)
                .InSingletonScope();

            Bind<IDocumentSession>()
                .ToMethod(c => c.Kernel.Get<IDocumentStore>().OpenSession())
                .InRequestScope();

            Bind<IAccountRepository>().To<RavenDbAccountRepository>();
            Bind<IPasswordStrategy>().To<HashPasswordStrategy>();
            Bind<IPasswordPolicy>().ToMethod(InitPasswordPolicy);
        }

        private IDocumentStore InitDocStore(IContext context)
        {
            var ds = new DocumentStore { ConnectionStringName = "CloudBird" };
            ds.Initialize();
            return ds;
        }

        private IPasswordPolicy InitPasswordPolicy(IContext context)
        {
            return new PasswordPolicy
                 {
                     IsPasswordQuestionRequired = false,
                     IsPasswordResetEnabled = true,
                     IsPasswordRetrievalEnabled = false,
                     MaxInvalidPasswordAttempts = 5,
                     MinRequiredNonAlphanumericCharacters = 0,
                     PasswordAttemptWindow = 10,
                     PasswordMinimumLength = 6,
                     PasswordStrengthRegularExpression = null
                 };
        }
    }
}