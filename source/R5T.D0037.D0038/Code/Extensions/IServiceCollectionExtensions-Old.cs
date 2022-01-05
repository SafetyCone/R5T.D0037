using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0038;

using R5T.Dacia;


namespace R5T.D0037.D0038
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="LibGit2SharpBasedGitOperator"/> implementation of <see cref="IGitOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddLibGit2SharpBasedGitOperator(this IServiceCollection services,
            IServiceAction<ILibGit2SharpOperator> libGit2SharpOperatorAction)
        {
            services
                .AddSingleton<IGitOperator, LibGit2SharpBasedGitOperator>()
                .Run(libGit2SharpOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="LibGit2SharpBasedGitOperator"/> implementation of <see cref="IGitOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IGitOperator> AddLibGit2SharpBasedGitOperatorAction(this IServiceCollection services,
            IServiceAction<ILibGit2SharpOperator> libGit2SharpOperatorAction)
        {
            var serviceAction = ServiceAction.New<IGitOperator>(() => services.AddLibGit2SharpBasedGitOperator(
                libGit2SharpOperatorAction));

            return serviceAction;
        }
    }
}
