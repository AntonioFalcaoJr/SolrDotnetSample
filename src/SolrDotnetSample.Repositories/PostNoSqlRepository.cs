using System;
using SolrDotnetSample.Repositories.Abstractions.NoSql;
using SolrDotnetSample.Repositories.Models;
using SolrNet;

namespace SolrDotnetSample.Repositories
{
    public class PostNoSqlRepository : NoSqlRepository<PostModel, Guid>, IPostNoSqlRepository
    {
        public PostNoSqlRepository(ISolrOperations<PostModel> solrOperations)
            : base(solrOperations) { }
    }
}