using System;
using SolrDotnetSample.Repositories.Abstractions.Relational;
using SolrDotnetSample.Repositories.Contexts;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories
{
    public class PostRelationRepository : RelationalRepository<PostModel, Guid>, IPostRelationalRepository
    {
        public PostRelationRepository(SolrDotnetSampleContext context)
            : base(context) { }
    }
}