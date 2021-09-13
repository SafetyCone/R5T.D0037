﻿using System;
using System.Threading.Tasks;

using R5T.D0037;
using R5T.T0010;


namespace System
{
    public static class IGitOperatorExtensions
    {
        /// <summary>
        /// Check-in is:
        ///     1) Stage all unstaged files.
        ///     2) Commit the staged changes.
        ///     3) Push the committed changes of the head branch to the remote.
        /// </summary>
        public static async Task CheckIn(this IGitOperator gitOperator,
            LocalRepositoryDirectoryPath localRepositoryDirectoryPath,
            string commitMessage)
        {
            await gitOperator.StageAllUnstagedPaths(localRepositoryDirectoryPath);

            await gitOperator.Commit(localRepositoryDirectoryPath, commitMessage);

            await gitOperator.Push(localRepositoryDirectoryPath);
        }

        public static async Task StageAllUnstagedPaths(this IGitOperator gitOperator,
            LocalRepositoryDirectoryPath localRepositoryDirectoryPath)
        {
            var unstagedPaths = await gitOperator.ListAllUnstagedPaths(localRepositoryDirectoryPath);

            await gitOperator.Stage(localRepositoryDirectoryPath,
                unstagedPaths);
        }
    }
}
