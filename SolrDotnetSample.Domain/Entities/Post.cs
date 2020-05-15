using System;
using SolrDotnetSample.Domain.Abstractions;

namespace SolrDotnetSample.Domain.Entities
{
    public class Post : Entity<Guid>
    {
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime IsSold { get; set; }
        public DateTime PostedDate { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }

        protected override void SetId(Guid id) => Guid.NewGuid();
    }
}