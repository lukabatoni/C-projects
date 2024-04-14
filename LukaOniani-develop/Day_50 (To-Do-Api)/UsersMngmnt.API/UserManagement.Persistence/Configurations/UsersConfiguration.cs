using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserManagement.Domain;
using UserManagement.Domain.Userss;

namespace UserManagement.Persistence.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<Userss>
    {
        public void Configure(EntityTypeBuilder<Userss> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Username).IsUnique();

            builder.Property(x => x.Username).IsUnicode(false).IsRequired().HasMaxLength(50);

            builder.Property(x => x.PasswordHash).IsRequired();

            builder.HasMany(x => x.ToDoes).WithOne(t => t.userss).HasForeignKey(t => t.OwnerId).OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Status).IsRequired().HasConversion(v => v.ToString(), v => (Enums.Status)Enum.Parse(typeof(Enums.Status), v));

            builder.Property(x => x.CreatedAt).IsRequired().HasColumnType("date");

            builder.Property(x => x.ModifiedAt).IsRequired().HasColumnType("date");

        }
    }
}
