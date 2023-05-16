using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Noobboyz.Models;

namespace Noobboyz.Configurations
{
    public class AspNetUserConfiguration : IEntityTypeConfiguration<AspNetUser>
    {
        public void Configure(EntityTypeBuilder<AspNetUser> builder)
        {
            builder.ToTable("tb_AspNetUser");
            builder.HasKey(x => x.Id);
        }
    }
}
