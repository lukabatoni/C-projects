using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserManagement.Domain;
using UserManagement.Domain.TO_DOs;


namespace UserManagement.Persistence.Configurations
{
    internal class TO_DOConfiguration : IEntityTypeConfiguration<ToDos>
    {
        public void Configure(EntityTypeBuilder<ToDos> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);

            builder.Property(x => x.Status).IsRequired().HasMaxLength(20); 

            builder.Property(x => x.TargetCompletionDate).HasColumnType("date"); 

            builder.HasMany(t => t.Subtasks).WithOne(s => s.ToDos).HasForeignKey(s => s.TodoItemId) .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.StatusEnum).IsRequired().HasConversion(v => v.ToString(), v => (Enums.Status)Enum.Parse(typeof(Enums.Status), v));

            builder.Property(x => x.CreatedAt).IsRequired().HasColumnType("date");

            builder.Property(x => x.ModifiedAt).IsRequired().HasColumnType("date");
        }
    }
}

