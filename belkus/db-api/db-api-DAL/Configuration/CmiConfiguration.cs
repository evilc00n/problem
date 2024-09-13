using db_api.Domain.Entities.Cmi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection.Emit;

namespace db_api_DAL.Configuration
{
    public class CmiUserConfiguration : IEntityTypeConfiguration<CmiUsers>
    {
        public void Configure(EntityTypeBuilder<CmiUsers> builder)
        {
            {
                builder.ToTable("cmi_users");

                builder.HasKey(u => u.Id);

                builder.Property(u => u.Id)
                    .HasColumnName("id")
                    .HasColumnType("int")
                    .IsRequired();

                builder.Property(u => u.PlayerUuid).HasColumnName("player_uuid").HasColumnType("text");
                builder.Property(u => u.Username).HasColumnName("username").HasColumnType("text");
                builder.Property(u => u.Nickname).HasColumnName("nickname").HasColumnType("text");
                builder.Property(u => u.LogOutLocation).HasColumnName("LogOutLocation").HasColumnType("text");
                builder.Property(u => u.DeathLocation).HasColumnName("DeathLocation").HasColumnType("text");
                builder.Property(u => u.TeleportLocation).HasColumnName("TeleportLocation").HasColumnType("text");
                builder.Property(u => u.Homes).HasColumnName("Homes").HasColumnType("text");
                builder.Property(u => u.LastLoginTime).HasColumnName("LastLoginTime").HasColumnType("bigint");
                builder.Property(u => u.LastLogoffTime).HasColumnName("LastLogoffTime").HasColumnType("bigint");
                builder.Property(u => u.TotalPlayTime).HasColumnName("TotalPlayTime").HasColumnType("bigint");
                builder.Property(u => u.TFly).HasColumnName("tFly").HasColumnType("bigint");
                builder.Property(u => u.TGod).HasColumnName("tGod").HasColumnType("bigint");
                builder.Property(u => u.Glow).HasColumnName("Glow").HasColumnType("text");
                builder.Property(u => u.Ips).HasColumnName("Ips").HasColumnType("text");
                builder.Property(u => u.Cuffed).HasColumnName("Cuffed").HasColumnType("tinyint");
                builder.Property(u => u.AlertUntil).HasColumnName("AlertUntil").HasColumnType("bigint");
                builder.Property(u => u.AlertReason).HasColumnName("AlertReason").HasColumnType("text");
                builder.Property(u => u.JoinedCounter).HasColumnName("JoinedCounter").HasColumnType("tinyint");
                builder.Property(u => u.LockedIps).HasColumnName("LockedIps").HasColumnType("text");
                builder.Property(u => u.PTime).HasColumnName("pTime").HasColumnType("bigint");
                builder.Property(u => u.Kits).HasColumnName("Kits").HasColumnType("text");
                builder.Property(u => u.Charges).HasColumnName("Charges").HasColumnType("text");
                builder.Property(u => u.Cooldowns).HasColumnName("Cooldowns").HasColumnType("mediumtext");
                builder.Property(u => u.Balance).HasColumnName("Balance").HasColumnType("double");
                builder.Property(u => u.Notes).HasColumnName("Notes").HasColumnType("text");
                builder.Property(u => u.Rank).HasColumnName("Rank").HasColumnType("text");
                builder.Property(u => u.BannedUntil).HasColumnName("BannedUntil").HasColumnType("bigint");
                builder.Property(u => u.BannedAt).HasColumnName("BannedAt").HasColumnType("bigint");
                builder.Property(u => u.BannedBy).HasColumnName("BannedBy").HasColumnType("text");
                builder.Property(u => u.BanReason).HasColumnName("BanReason").HasColumnType("text");
                builder.Property(u => u.Ignores).HasColumnName("Ignores").HasColumnType("text");
                builder.Property(u => u.Vanish).HasColumnName("Vanish").HasColumnType("text");
                builder.Property(u => u.Economy).HasColumnName("Economy").HasColumnType("text");
                builder.Property(u => u.Mail).HasColumnName("Mail").HasColumnType("mediumtext");
                builder.Property(u => u.FlightCharge).HasColumnName("FlightCharge").HasColumnType("double");
                builder.Property(u => u.UserMeta).HasColumnName("UserMeta").HasColumnType("text");
                builder.Property(u => u.Flying).HasColumnName("Flying").HasColumnType("tinyint");
                builder.Property(u => u.Votifier).HasColumnName("Votifier").HasColumnType("int");
                builder.Property(u => u.Jail).HasColumnName("Jail").HasColumnType("text");
                builder.Property(u => u.JailedUntil).HasColumnName("JailedUntil").HasColumnType("bigint");
                builder.Property(u => u.FakeAccount).HasColumnName("FakeAccount").HasColumnType("tinyint");
                builder.Property(u => u.PlaytimeOptimized).HasColumnName("PlaytimeOptimized").HasColumnType("bigint");
                builder.Property(u => u.FlightChargeEnabled).HasColumnName("flightChargeEnabled").HasColumnType("tinyint");
                builder.Property(u => u.JailReason).HasColumnName("JailReason").HasColumnType("text");
                builder.Property(u => u.Skin).HasColumnName("Skin").HasColumnType("text");
                builder.Property(u => u.Collision).HasColumnName("Collision").HasColumnType("tinyint");
                builder.Property(u => u.NamePrefix).HasColumnName("NamePrefix").HasColumnType("text");
                builder.Property(u => u.NameSuffix).HasColumnName("NameSuffix").HasColumnType("text");
                builder.Property(u => u.Warnings).HasColumnName("Warnings").HasColumnType("text");
                builder.Property(u => u.NameColor).HasColumnName("NameColor").HasColumnType("text");
                builder.Property(u => u.Muted).HasColumnName("Muted").HasColumnType("text");
                builder.Property(u => u.AFRecharge).HasColumnName("AFRecharge").HasColumnType("text");
                builder.Property(u => u.DisplayName).HasColumnName("DisplayName").HasColumnType("text");
                builder.Property(u => u.Options).HasColumnName("Options").HasColumnType("text");
                builder.Property(u => u.ChatColor).HasColumnName("ChatColor").HasColumnType("text");

            }
        }
    }
}
