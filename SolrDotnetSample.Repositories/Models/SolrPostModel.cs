using System;
using SolrDotnetSample.Domain.Entities;
using SolrDotnetSample.Repositories.Abstractions;
using SolrNet.Attributes;

namespace SolrDotnetSample.Repositories.Models
{
    public class SolrPostModel : Model<Guid>
    {
        public SolrPostModel() { }

        public SolrPostModel(Post model)
        {
            Id = model.Id;
            Description = model.Description;
            IsActive = model.IsActive;
            Price = model.Price;
            Title = model.Title;
        }

        [SolrField("description")]
        public string Description { get; set; }

        [SolrUniqueKey("id")]
        public Guid Id { get; set; }

        [SolrField("isActive")]
        public bool IsActive { get; set; }

        [SolrField("price")]
        public double Price { get; set; }

        [SolrField("title")]
        public string Title { get; set; }
    }
}