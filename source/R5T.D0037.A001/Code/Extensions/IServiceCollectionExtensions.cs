using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Suebia;

using R5T.D0037.D0038;
using R5T.D0038.A001;


namespace R5T.D0037.A001
{
    public static class IServiceCollectionExtensions
    {
        public static ServiceAggregation AddGitOperatorServiceActions(this IServiceCollection services,
            IServiceAction<ISecretsDirectoryFilePathProvider> secretsDirectoryFilePathProviderAction)
        {
            var libGit2SharpOperatorServiceActions = services.AddLibGit2SharpOperatorServiceActions(
                secretsDirectoryFilePathProviderAction);

            var libGit2SharpBasedGitOperatorAction = services.AddLibGit2SharpBasedGitOperatorAction(
                libGit2SharpOperatorServiceActions.LibGit2SharpOperatorAction);

            var output = new ServiceAggregation
            {
                GitOperatorAction = libGit2SharpBasedGitOperatorAction,
            }
            .FillFrom(libGit2SharpOperatorServiceActions)
            ;

            return output;
        }
    }
}
