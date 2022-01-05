using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.D0038;
using R5T.T0010;
using R5T.T0064;


namespace R5T.D0037.D0038
{
    [ServiceImplementationMarker]
    public class LibGit2SharpBasedGitOperator : IGitOperator, IServiceImplementation
    {
        private ILibGit2SharpOperator LibGit2SharpOperator { get; }


        public Task<string> Clone(
            string sourceUrl,
            LocalRepositoryDirectoryPath localRepositoryDirectoryPath)
        {
            return this.LibGit2SharpOperator.CloneNonIdempotent(
                sourceUrl,
                localRepositoryDirectoryPath);
        }

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

        public Task Commit(LocalRepositoryDirectoryPath localRepositoryDirectoryPath, string commitMessage)
        {
            return this.LibGit2SharpOperator.Commit(localRepositoryDirectoryPath,
                commitMessage);
        }

        public Task<string[]> ListAllUnstagedPaths(LocalRepositoryDirectoryPath localRepositoryDirectoryPath)
        {
            return this.LibGit2SharpOperator.ListAllUnstagedPaths(localRepositoryDirectoryPath);
        }

        public Task Push(LocalRepositoryDirectoryPath localRepositoryDirectoryPath)
        {
            return this.LibGit2SharpOperator.Push(localRepositoryDirectoryPath);
        }

        public Task Stage(LocalRepositoryDirectoryPath localRepositoryDirectoryPath, IEnumerable<string> filePaths)
        {
            return this.LibGit2SharpOperator.Stage(localRepositoryDirectoryPath, filePaths);
        }
    }
}
