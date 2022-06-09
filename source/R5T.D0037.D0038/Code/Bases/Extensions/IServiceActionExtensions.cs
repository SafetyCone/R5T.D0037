using System;

using R5T.D0038;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0037.D0038
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LibGit2SharpBasedGitOperator"/> implementation of <see cref="IGitOperator"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitOperator> AddLibGit2SharpBasedGitOperatorAction(this IServiceAction _,
            IServiceAction<ILibGit2SharpOperator> libGit2SharpOperatorAction)
        {
            var serviceAction = _.New<IGitOperator>(services => services.AddLibGit2SharpBasedGitOperator(
                libGit2SharpOperatorAction));

            return serviceAction;
        }
    }
}
