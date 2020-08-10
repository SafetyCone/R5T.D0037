using System;
using System.Threading.Tasks;

using R5T.D0038;
using R5T.T0010;


namespace R5T.D0037.D0038
{
    public class LibGit2SharpBasedGitOperator : IGitOperator
    {
        private ILibGit2SharpOperator LibGit2SharpOperator { get; }


        public LibGit2SharpBasedGitOperator(ILibGit2SharpOperator libGit2SharpOperator)
        {
            this.LibGit2SharpOperator = libGit2SharpOperator;
        }

        public Task<bool> HasUnpushedLocalChanges(LocalRepositoryDirectoryPath repositoryDirectoryPath)
        {
            var hasUnpushedLocalChanges = this.LibGit2SharpOperator.HasUnpushedLocalChanges(repositoryDirectoryPath);

            return Task.FromResult(hasUnpushedLocalChanges);
        }

        public Task<bool> HasUnpulledOriginMasterChanges(LocalRepositoryDirectoryPath repositoryDirectoryPath)
        {
            var hasUnpulledMasterBranchChanges = this.LibGit2SharpOperator.HasUnpulledMasterBranchChanges(repositoryDirectoryPath);

            return Task.FromResult(hasUnpulledMasterBranchChanges);
        }

        public Task<RemoteRepositoryUrl> GetOriginRepositoryUrlAsync(LocalRepositoryContainedPath path)
        {
            var originRepositoryUrl = this.LibGit2SharpOperator.GetRemoteOriginUrl(path);

            return Task.FromResult(originRepositoryUrl);
        }

        public Task<RevisionIdentity> GetLatestLocalMasterRevision(LocalRepositoryContainedPath path)
        {
            var latestLocalMasterRevision = this.LibGit2SharpOperator.GetLatestLocalMasterRevision(path);

            return Task.FromResult(latestLocalMasterRevision);
        }
    }
}
