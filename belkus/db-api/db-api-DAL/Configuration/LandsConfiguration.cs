
using db_api.Domain.Entities.Lands;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace db_api_DAL.Configuration
{
    public class LandsLandsConfiguration : IEntityTypeConfiguration<LandsLands>
    {
        public void Configure(EntityTypeBuilder<LandsLands> builder)
        {
            builder.ToTable("lands_lands");

            builder.HasKey(e => e.Ulid)
                   .HasName("PRIMARY");

            builder.HasIndex(e => e.Server)
                   .HasDatabaseName("server");

            builder.HasIndex(e => e.World)
                   .HasDatabaseName("world");

            builder.Property(e => e.Ulid)
                   .HasColumnType("char(26)")
                   .HasColumnName("ulid")
                   .IsRequired();

            builder.Property(e => e.Server)
                   .HasColumnType("varchar(32)")
                   .HasColumnName("server")
                   .IsRequired();

            builder.Property(e => e.World)
                   .HasColumnType("char(26)")
                   .HasColumnName("world")
                   .IsRequired();

            builder.Property(e => e.Type)
                   .HasColumnType("tinytext")
                   .HasColumnName("type")
                   .IsRequired();

            builder.Property(e => e.Category)
                   .HasColumnType("tinytext")
                   .HasColumnName("category")
                   .IsRequired(false);

            builder.Property(e => e.Name)
                   .HasColumnType("tinytext")
                   .HasColumnName("name")
                   .IsRequired();

            builder.Property(e => e.Nation)
                   .HasColumnType("char(26)")
                   .HasColumnName("nation")
                   .IsRequired(false);

            builder.Property(e => e.Area)
                   .HasColumnType("mediumtext")
                   .HasColumnName("area")
                   .IsRequired();

            builder.Property(e => e.Members)
                   .HasColumnType("text")
                   .HasColumnName("members")
                   .IsRequired();

            builder.Property(e => e.CreatedAt)
                   .HasColumnType("timestamp")
                   .HasColumnName("created_at")
                   .IsRequired();

            builder.Property(e => e.Balance)
                   .HasColumnType("float")
                   .HasDefaultValue(0)
                   .HasColumnName("balance")
                   .IsRequired();

            builder.Property(e => e.Title)
                   .HasColumnType("varchar(300)")
                   .HasColumnName("title")
                   .IsRequired(false);
            builder.Property(e => e.Spawn)
                    .HasColumnType("text")
                    .HasColumnName("spawn")
                    .IsRequired(false);

            builder.Property(e => e.Inbox)
                   .HasColumnType("text")
                   .HasColumnName("inbox")
                   .IsRequired(false);

            builder.Property(e => e.Limits)
                   .HasColumnType("text")
                   .HasColumnName("limits")
                   .IsRequired(false);

            builder.Property(e => e.Shield)
                   .HasColumnType("bigint(20)")
                   .HasDefaultValue(0)
                   .HasColumnName("shield")
                   .IsRequired();

            builder.Property(e => e.Stats)
                   .HasColumnType("text")
                   .HasColumnName("stats")
                   .IsRequired(false);

            builder.Property(e => e.Icon)
                   .HasColumnType("text")
                   .HasColumnName("icon")
                   .IsRequired(false);

            builder.Property(e => e.Storage)
                   .HasColumnType("longtext")
                   .HasColumnName("storage")
                   .IsRequired(false);

            builder.Property(e => e.Level)
                   .HasColumnType("smallint(6)")
                   .HasColumnName("level")
                   .IsRequired();

            // Настройка внешних ключей
            builder.HasOne<LandsServers>()
                   .WithMany()
                   .HasForeignKey(e => e.Server)
                   .HasConstraintName("lands_lands_ibfk_1")
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<LandsWorlds>()
                   .WithMany()
                   .HasForeignKey(e => e.World)
                   .HasConstraintName("lands_lands_ibfk_2")
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }

    public class LandsPlayersConfiguration : IEntityTypeConfiguration<LandsPlayers>
    {
        public void Configure(EntityTypeBuilder<LandsPlayers> builder)
        {
            builder.ToTable("lands_players");

            builder.HasKey(p => p.Uuid);

            builder.Property(p => p.Uuid)
                .HasColumnType("char(36)")
                .HasColumnName("uuid")
                .IsRequired();

            builder.Property(p => p.Name)
                .HasColumnType("varchar(16)")
                .HasColumnName("name")
                .IsRequired();

            builder.Property(p => p.EditLand)
                .HasColumnType("char(26)")
                .HasColumnName("edit_land")
                .HasDefaultValue(null);

            builder.Property(p => p.Invites)
                .HasColumnType("text")
                .HasColumnName("invites")
                .HasDefaultValue(null);

            builder.Property(p => p.Limits)
                .HasColumnType("text")
                .HasColumnName("limits")
                .HasDefaultValue(null);

            builder.Property(p => p.Chatmode)
                .HasColumnType("tinytext")
                .HasColumnName("chatmode")
                .HasDefaultValue(null);

            builder.Property(p => p.Flags)
                .HasColumnType("text")
                .HasColumnName("flags")
                .HasDefaultValue(null);

            builder.HasIndex(p => p.EditLand).HasDatabaseName("edit_land");

            builder.HasOne<LandsLands>()
                .WithMany()
                .HasForeignKey(p => p.EditLand)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("lands_players_ibfk_1");
        }


        public class LandsServersConfiguration : IEntityTypeConfiguration<LandsServers>
        {
            public void Configure(EntityTypeBuilder<LandsServers> builder)
            {
                builder.ToTable("lands_servers");

                builder.HasKey(s => s.Server);

                builder.Property(s => s.Server)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("server")
                    .IsRequired();

                builder.Property(s => s.LastSeen)
                    .HasColumnType("timestamp")
                    .HasColumnName("last_seen")
                    .IsRequired();

                builder.Property(s => s.Version)
                    .HasColumnType("tinytext")
                    .HasColumnName("version")
                    .IsRequired();

                builder.Property(s => s.VersionPrev)
                    .HasColumnType("tinytext")
                    .HasColumnName("version_prev")
                    .IsRequired();

                builder.Property(s => s.Timestamps)
                    .HasColumnType("text")
                    .HasColumnName("timestamps")
                    .HasDefaultValue(null);

                builder.Property(s => s.Flags)
                    .HasColumnType("text")
                    .HasColumnName("flags")
                    .HasDefaultValue(null);
            }
        }

        public class LandsWorldsConfiguration : IEntityTypeConfiguration<LandsWorlds>
        {
            public void Configure(EntityTypeBuilder<LandsWorlds> builder)
            {
                builder.ToTable("lands_worlds");

                builder.HasKey(w => w.Ulid);

                builder.Property(w => w.Ulid)
                    .HasColumnType("char(26)")
                    .HasColumnName("ulid")
                    .IsRequired();

                builder.Property(w => w.Server)
                    .HasColumnType("varchar(32)")
                    .HasColumnName("server")
                    .IsRequired();

                builder.Property(w => w.Name)
                    .HasColumnType("tinytext")
                    .HasColumnName("name")
                    .IsRequired();

                builder.Property(w => w.Uid)
                    .HasColumnType("char(36)")
                    .HasColumnName("uid")
                    .IsRequired();

                builder.Property(w => w.FlagsRole)
                    .HasColumnType("text")
                    .HasColumnName("flags_role")
                    .HasDefaultValue(null);

                builder.Property(w => w.FlagsNatural)
                    .HasColumnType("text")
                    .HasColumnName("flags_natural")
                    .HasDefaultValue(null);

                builder.HasIndex(w => w.Server).HasDatabaseName("server");

                builder.HasOne<LandsServers>()
                    .WithMany()
                    .HasForeignKey(w => w.Server)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("lands_worlds_ibfk_1");
            }
        }



    }




}
