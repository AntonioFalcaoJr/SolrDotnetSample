using System;
using Microsoft.EntityFrameworkCore;
using SolrDotnetSample.Repositories.Abstractions.Relational;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories
{
    public class PostRelationRepository : RelationalRepository<PostModel, Guid>, IPostRelationalRepository
    {
        public PostRelationRepository(DbContext context)
            : base(context) { }
    }
}