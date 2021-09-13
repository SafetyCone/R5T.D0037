using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Magyar;
using R5T.Suebia;

using R5T.D0037.D0038;
using R5T.D0038.A002;
using R5T.D0082.D001;


namespace R5T.D0037.A002
{
    public static class IServiceCollectionExtensions
    {
        public static ServiceAggregation AddGitOperatorServices(this IServiceCollection services,
            IServiceAction<IGitHubAuthenticationProvider> gitHubAuthenticationProviderAction,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            var libGit2SharpOperatorServiceActions = services.AddLibGit2SharpOperatorServiceActions(
                gitHubAuthenticationProviderAction,
                secretsDirectoryFilePathProviderAction);

            var libGit2SharpBasedGitOperatorAction = services.AddLibGit2SharpBasedGitOperatorAction(
                libGit2SharpOperatorServiceActions.LibGit2SharpOperatorAction);

            return new ServiceAggregation()
                .As<ServiceAggregation, IServiceAggregationIncrement>(increment =>
                {
                    increment.GitOperatorAction = libGit2SharpBasedGitOperatorAction;
                })
                .FillFrom(libGit2SharpOperatorServiceActions)
                ;
        }
    }
}
