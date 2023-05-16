using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Noobboyz.Models;

namespace Noobboyz.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.ToTable("tb_News");
            builder.HasKey(x => x.NewsId);
            builder.HasOne(p => p.Category)
                .WithMany(p => p.news)
                .HasForeignKey(p => p.NewsId);

        }
    }
}
