using db_api.Domain.Entities.Playerpoints;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace db_api_DAL.Configuration
{
    public class PlayerpointsPointsConfiguration : IEntityTypeConfiguration<PlayerpointsPoints>
    {
        public void Configure(EntityTypeBuilder<PlayerpointsPoints> builder)
        {
            // Установка имени таблицы
            builder.ToTable("playerpoints_points");

            // Настройка первичного ключа
            builder.HasKey(p => p.Id);

            // Настройка столбца Id
            builder.Property(p => p.Id)
                .HasColumnName("id")
                .HasColumnType("int(11)")
                .IsRequired()
                .ValueGeneratedOnAdd();

            // Настройка столбца Uuid
            builder.Property(p => p.Uuid)
                .HasColumnName("uuid")
                .HasColumnType("varchar(36)")
                .IsRequired();

            // Уникальный ключ на Uuid
            builder.HasIndex(p => p.Uuid)
                .IsUnique();

            // Настройка столбца Points
            builder.Property(p => p.Points)
                .HasColumnName("points")
                .HasColumnType("int(11)")
                .IsRequired();
        }
    }
}
