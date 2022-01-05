using System;

using R5T.Magyar;
using R5T.Suebia;

using R5T.D0037.D0038;
using R5T.D0038.A002;
using R5T.D0082.D001;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0037.A002
{
    public static class IServiceActionExtensions
    {
        public static ServiceActionAggregation AddGitOperatorServices(this IServiceAction _,
            IServiceAction<IGitHubAuthenticationProvider> gitHubAuthenticationProviderAction,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            var libGit2SharpOperatorServiceActions = _.AddLibGit2SharpOperatorServiceActions(
                gitHubAuthenticationProviderAction,
                secretsDirectoryFilePathProviderAction);

            var libGit2SharpBasedGitOperatorAction = _.AddLibGit2SharpBasedGitOperatorAction(
                libGit2SharpOperatorServiceActions.LibGit2SharpOperatorAction);

            var output = new ServiceActionAggregation()
                .As<ServiceActionAggregation, IServiceActionAggregationIncrement>(increment =>
                {
                    increment.GitOperatorAction = libGit2SharpBasedGitOperatorAction;
                })
                .FillFrom(libGit2SharpOperatorServiceActions)
                ;

            return output;
        }
    }
}
