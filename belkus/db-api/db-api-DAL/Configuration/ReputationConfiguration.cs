using db_api.Domain.Entities.Reputation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace db_api_DAL.Configuration
{
    public class ReputationConfiguration : IEntityTypeConfiguration<Reputation>
    {
        public void Configure(EntityTypeBuilder<Reputation> builder)
        {
            // Устанавливаем имя таблицы
            builder.ToTable("reputation");

            // Настройка первичного ключа
            builder.HasKey(r => r.Id)
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexType", "BTREE");

            // Настройка поля Id
            builder.Property(r => r.Id)
                .HasColumnName("id")
                .HasColumnType("bigint(50)")
                .IsRequired();

            // Настройка поля Uuid
            builder.Property(r => r.Uuid)
                .HasColumnName("uuid")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            // Настройка поля Reputation
            builder.Property(r => r.ReputationScore)
                .HasColumnName("reputation")
                .HasColumnType("bigint(50)");

            // Настройка поля AcceptReputation
            builder.Property(r => r.AcceptReputation)
                .HasColumnName("acceptReputation")
                .HasColumnType("tinyint(1)");
        }
    }
}
