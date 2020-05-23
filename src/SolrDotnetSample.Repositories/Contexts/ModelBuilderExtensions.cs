using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories.Contexts
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var posts = new List<PostModel>();

            for (var i = 0; i < 500; i++)
                posts.Add(new PostModel
                {
                    Id = Guid.NewGuid(),
                    Description = "Description",
                    ExpiryDate = DateTime.Now,
                    IsSold = true,
                    IsActive = true,
                    PostDate = DateTime.Now,
                    Price = 0, Title = "Title"
                });

            modelBuilder
               .Entity<PostModel>()
               .HasData(posts);
        }
    }
}