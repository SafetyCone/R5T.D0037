using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0010;
using R5T.T0064;


namespace R5T.D0037
{
    [ServiceDefinitionMarker]
    public interface IGitOperator : IServiceDefinition
    {
        Task<string> Clone(
            string sourceUrl,
            LocalRepositoryDirectoryPath localRepositoryDirectoryPath);

        Task Commit(LocalRepositoryDirectoryPath localRepositoryDirectoryPath,
            string commitMessage);

        Task Fetch(LocalRepositoryDirectoryPath localRepositoryDirectoryPath);

        /// <summary>
        /// Determines if a local repository has changes that have not been pushed to the remote repository.
        /// This could happen if:
        /// * Untracked files.
        /// * Unstaged changes.
        /// * Committed changes that have not been pushed to the remote.
        /// </summary>
        Task<bool> HasUnpushedLocalChanges(LocalRepositoryDirectoryPath localRepositoryDirectoryPath);

        /// <summary>
        /// Determines if a local repository's master branch is missing commits that exist the remote repository.
        /// </summary>
        Task<bool> HasUnpulledOriginMasterChanges(LocalRepositoryDirectoryPath localRepositoryDirectoryPath);

        /// <summary>
        /// Gets the origin repository URL for a file or directory path within a local repository.
        /// </summary>
        Task<RemoteRepositoryUrl> GetOriginRepositoryUrlAsync(LocalRepositoryContainedPath localPath);

        /// <summary>
        /// Gets the latest revision for the master branch of the local repository containing the file or directory path, *not* the file or directory itself.
        /// </summary>
        Task<RevisionIdentity> GetLatestLocalMasterRevision(LocalRepositoryContainedPath localPath);

        Task<string[]> ListAllUnstagedPaths(LocalRepositoryDirectoryPath localRepositoryDirectoryPath);

        Task Push(LocalRepositoryDirectoryPath localRepositoryDirectoryPath);

        Task Stage(LocalRepositoryDirectoryPath localRepositoryDirectoryPath,
            IEnumerable<string> filePaths);
    }
}
