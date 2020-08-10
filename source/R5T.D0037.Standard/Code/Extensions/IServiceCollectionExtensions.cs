using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0037;
using R5T.D0037.D0038;
using R5T.D0038;
using R5T.D0038.L0001;

using R5T.Dacia;


namespace R5T.D0037.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IGitOperator"/> service.
        /// </summary>
        public static
            (
            IServiceAction<IGitOperator> Main,
            IServiceAction<ILibGit2SharpOperator> libGit2SharpOperatorAction
            )
        AddGitOperatorAction(this IServiceCollection services)
        {
            var libGit2SharpOperatorAction = services.AddLibGit2SharpOperatorAction();

            var gitOperatorAction = services.AddLibGit2SharpBasedGitOperatorAction(
                libGit2SharpOperatorAction);

            return
                (
                gitOperatorAction,
                libGit2SharpOperatorAction
                );
        }

        /// <summary>
        /// Adds the <see cref="IGitOperator"/> service.
        /// </summary>
        public static IServiceCollection AddGitOperator(this IServiceCollection services)
        {
            var gitOperatorAction = services.AddGitOperatorAction();

            services.Run(gitOperatorAction.Main);

            return services;
        }
    }
}
