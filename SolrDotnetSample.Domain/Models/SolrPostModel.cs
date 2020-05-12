using System;
using poc_console_solr.Domain.Entities;
using SolrNet.Attributes;

namespace poc_console_solr.Domain.Models
{
    public class SolrPostModel
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