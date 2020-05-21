using System;
using SolrDotnetSample.Repositories.Abstractions;
using SolrNet.Attributes;

namespace SolrDotnetSample.Repositories.Models
{
    public class PostModel : Model<Guid>
    {
        [SolrField("Description")]
        public string Description { get; set; }

        [SolrField("ExpiryDate")]
        public DateTime ExpiryDate { get; set; }

        [SolrField("IsActive")]
        public bool IsActive { get; set; }

        [SolrField("IsSold")]
        public bool IsSold { get; set; }

        [SolrField("PostDate")]
        public DateTime PostDate { get; set; }

        [SolrField("Price")]
        public double Price { get; set; }

        [SolrField("Title")]
        public string Title { get; set; }
    }
}