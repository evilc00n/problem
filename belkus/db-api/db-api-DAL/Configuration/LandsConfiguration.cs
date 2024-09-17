
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

            builder.HasKey(e => e.Ulid);

            builder.Property(e => e.Ulid)
                .HasColumnName("ulid")
                .HasMaxLength(26)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(e => e.Server)
                .HasColumnName("server")
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(e => e.World)
                .HasColumnName("world")
                .HasMaxLength(26)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(e => e.Type)
                .HasColumnName("type")
                .IsRequired();

            builder.Property(e => e.Category)
                .HasColumnName("category");

            builder.Property(e => e.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(e => e.Nation)
                .HasColumnName("nation")
                .HasMaxLength(26)
                .IsUnicode(false);

            builder.Property(e => e.Area)
                .HasColumnName("area")
                .IsRequired();

            builder.Property(e => e.Members)
                .HasColumnName("members")
                .IsRequired();

            builder.Property(e => e.CreatedAt)
                .HasColumnName("created_at")
                .IsRequired();

            builder.Property(e => e.Balance)
                .HasColumnName("balance")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(e => e.Title)
                .HasColumnName("title")
                .HasMaxLength(300);

            builder.Property(e => e.Spawn)
                .HasColumnName("spawn");

            builder.Property(e => e.Inbox)
                .HasColumnName("inbox");

            builder.Property(e => e.Limits)
                .HasColumnName("limits");

            builder.Property(e => e.Shield)
                .HasColumnName("shield")
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(e => e.Stats)
                .HasColumnName("stats");

            builder.Property(e => e.Icon)
                .HasColumnName("icon");

            builder.Property(e => e.Storage)
                .HasColumnName("storage");

            builder.Property(e => e.Level)
                .HasColumnName("level")
                .IsRequired();

            builder.HasOne(e => e.LandsServer)
                .WithMany(e => e.Lands)
                .HasForeignKey(e => e.Server)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.LandsWorld)
                .WithMany(e => e.Lands)
                .HasForeignKey(e => e.World)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }

    public class LandsPlayersConfiguration : IEntityTypeConfiguration<LandsPlayers>
    {
        public void Configure(EntityTypeBuilder<LandsPlayers> builder)
        {
            builder.ToTable("lands_players");

            builder.HasKey(e => e.Uuid);

            builder.Property(e => e.Uuid)
                .HasColumnName("uuid")
                .HasMaxLength(36)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(e => e.Name)
                .HasColumnName("name")
                .HasMaxLength(16)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(e => e.EditLand)
                .HasColumnName("edit_land")
                .HasMaxLength(26)
                .IsUnicode(false);

            builder.Property(e => e.Invites)
                .HasColumnName("invites");

            builder.Property(e => e.Limits)
                .HasColumnName("limits");

            builder.Property(e => e.Chatmode)
                .HasColumnName("chatmode");

            builder.Property(e => e.Flags)
                .HasColumnName("flags");

            builder.HasOne(e => e.EditLandNavigation)
                .WithMany()
                .HasForeignKey(e => e.EditLand)
                .OnDelete(DeleteBehavior.SetNull);
        }


        public class LandsServersConfiguration : IEntityTypeConfiguration<LandsServers>
        {
            public void Configure(EntityTypeBuilder<LandsServers> builder)
            {
                builder.ToTable("lands_servers");

                builder.HasKey(e => e.Server);

                builder.Property(e => e.Server)
                    .HasColumnName("server")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsRequired();

                builder.Property(e => e.LastSeen)
                    .HasColumnName("last_seen")
                    .IsRequired();

                builder.Property(e => e.Version)
                    .HasColumnName("version")
                    .IsRequired();

                builder.Property(e => e.VersionPrev)
                    .HasColumnName("version_prev")
                    .IsRequired();

                builder.Property(e => e.Timestamps)
                    .HasColumnName("timestamps");

                builder.Property(e => e.Flags)
                    .HasColumnName("flags");

                builder.HasMany(e => e.Worlds)
                    .WithOne(e => e.LandsServer)
                    .HasForeignKey(e => e.Server)
                    .OnDelete(DeleteBehavior.Cascade);

                builder.HasMany(e => e.Lands)
                    .WithOne(e => e.LandsServer)
                    .HasForeignKey(e => e.Server)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }

        public class LandsWorldsConfiguration : IEntityTypeConfiguration<LandsWorlds>
        {
            public void Configure(EntityTypeBuilder<LandsWorlds> builder)
            {
                builder.ToTable("lands_worlds");

                builder.HasKey(e => e.Ulid);

                builder.Property(e => e.Ulid)
                    .HasColumnName("ulid")
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .IsRequired();

                builder.Property(e => e.Server)
                    .HasColumnName("server")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsRequired();

                builder.Property(e => e.Name)
                    .HasColumnName("name")
                    .IsRequired();

                builder.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .IsRequired();

                builder.Property(e => e.FlagsRole)
                    .HasColumnName("flags_role");

                builder.Property(e => e.FlagsNatural)
                    .HasColumnName("flags_natural");

                builder.HasOne(e => e.LandsServer)
                    .WithMany(e => e.Worlds)
                    .HasForeignKey(e => e.Server)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        }



    }




}
