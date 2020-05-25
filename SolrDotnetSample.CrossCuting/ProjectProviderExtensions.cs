using System.IO;
using System.Linq;

namespace SolrDotnetSample.CrossCuting
{
    public static class ProjectProviderExtensions
    {
        public static DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && directory.GetFiles("*.sln").Any() == false) directory = directory.Parent;
            return directory;
        }
    }
}