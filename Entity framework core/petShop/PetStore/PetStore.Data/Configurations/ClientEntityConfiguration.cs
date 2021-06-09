using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetSoreModels;

namespace PetStore.Data.Configurations
{
    public class ClientEntityConfiguration :
         IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .Property(c => c.UserName)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder
                .Property(c => c.Email)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder
                .Property(c => c.FirstName)
                .HasMaxLength(30)
                .IsUnicode(true);

            builder
                .Property(c => c.LastName)
                .HasMaxLength(30)
                .IsUnicode(true);
        }
    }
}
