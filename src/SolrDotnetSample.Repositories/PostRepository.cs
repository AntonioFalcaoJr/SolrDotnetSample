using System;
using SolrDotnetSample.Repositories.Abstractions.NoSql;
using SolrDotnetSample.Repositories.Models;
using SolrNet;

namespace SolrDotnetSample.Repositories
{
    public class PostRepository : NoSqlRepository<PostModel, Guid>, IPostRepository
    {
        public PostRepository(ISolrOperations<PostModel> solrOperations)
            : base(solrOperations) { }
    }
}