using System;

using R5T.Dacia;

using R5T.D0038;
using R5T.D0046;
using R5T.D0082.D001;


namespace R5T.D0037.A001
{
    public class ServiceAggregation : IServiceAggregation
    {
        public IServiceAction<IGitOperator> GitOperatorAction { get; set; }
        public IServiceAction<ILibGit2SharpOperator> LibGit2SharpOperatorAction { get; set; }
        public IServiceAction<IGitAuthenticationProvider> GitAuthenticationProviderAction { get; set; }
        public IServiceAction<IGitHubAuthenticationProvider> GitHubAuthenticationProviderAction { get; set; }
    }
}
