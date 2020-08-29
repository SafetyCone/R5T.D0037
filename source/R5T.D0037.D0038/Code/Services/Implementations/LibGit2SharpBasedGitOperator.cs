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
            return this.LibGit2SharpOperator.HasUnpushedLocalChanges(repositoryDirectoryPath);
        }

        public Task<bool> HasUnpulledOriginMasterChanges(LocalRepositoryDirectoryPath repositoryDirectoryPath)
        {
            return this.LibGit2SharpOperator.HasUnpulledMasterBranchChanges(repositoryDirectoryPath);
        }

        public Task<RemoteRepositoryUrl> GetOriginRepositoryUrlAsync(LocalRepositoryContainedPath path)
        {
            return this.LibGit2SharpOperator.GetRemoteOriginUrl(path);
        }

        public Task<RevisionIdentity> GetLatestLocalMasterRevision(LocalRepositoryContainedPath path)
        {
            return this.LibGit2SharpOperator.GetLatestLocalMasterRevision(path);
        }

        public Task Fetch(LocalRepositoryDirectoryPath localRepositoryDirectoryPath)
        {
            return this.LibGit2SharpOperator.Fetch(localRepositoryDirectoryPath);
        }
    }
}
