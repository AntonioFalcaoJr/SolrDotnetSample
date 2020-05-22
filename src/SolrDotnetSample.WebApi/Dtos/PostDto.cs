using System;
using SolrDotnetSample.Services.Abstractions;

namespace SolrDotnetSample.WebApi.Dtos
{
    public class PostDto : Dto<Guid>
    {
        public string Description { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsSold { get; set; }
        public DateTime PostDate { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
    }
}