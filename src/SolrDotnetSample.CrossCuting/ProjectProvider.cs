using System;
using System.IO;
using System.Linq;

namespace SolrDotnetSample.CrossCuting
{
    public static class ProjectProvider
    {
        public static DirectoryInfo TryGetSolutionDirectoryInfo(DirectoryInfo currentPath = null)
        {
            var directory = currentPath ?? new DirectoryInfo(Directory.GetCurrentDirectory());
            return directory.GetFiles("*.sln").Any() ? directory : TryGetSolutionDirectoryInfo(directory.Parent);
        }
    }
}