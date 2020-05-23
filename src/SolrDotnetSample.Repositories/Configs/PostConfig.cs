using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolrDotnetSample.Repositories.Models;

namespace SolrDotnetSample.Repositories.Configs
{
    public class PostConfig : IEntityTypeConfiguration<PostModel>
    {
        public void Configure(EntityTypeBuilder<PostModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.PostDate).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.ExpiryDate);
            builder.Property(x => x.IsActive);
            builder.Property(x => x.IsSold);
        }
    }
}