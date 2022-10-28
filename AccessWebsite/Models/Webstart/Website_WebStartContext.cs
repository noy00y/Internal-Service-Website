using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AccessWebsite.Models.Webstart
{
    public partial class Website_WebStartContext : DbContext
    {
        public Website_WebStartContext()
        {
        }

        public Website_WebStartContext(DbContextOptions<Website_WebStartContext> options)
            : base(options)
        {
        }

        public virtual DbSet<VwWebSession> VwWebSessions { get; set; }
        public virtual DbSet<VwWebSessionRpt> VwWebSessionRpts { get; set; }
        public virtual DbSet<WebSession> WebSessions { get; set; }
        public virtual DbSet<WebSessionIdssrvsql> WebSessionIdssrvsqls { get; set; }
        public virtual DbSet<WebSessionRpt> WebSessionRpts { get; set; }
        public virtual DbSet<WebUser> WebUsers { get; set; }
        public virtual DbSet<ZWebuser20220314> ZWebuser20220314s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SQL307\\SQL2012;Database=Website_WebStart;User Id = Webdevelop; Password = Ipex1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<VwWebSession>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WebSession");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentRecap)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WebUser)
                    .IsRequired()
                    .HasMaxLength(201)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwWebSessionRpt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_WebSessionRPT");

                entity.Property(e => e.Agent)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentRecap)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDuration).HasColumnType("numeric(17, 6)");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WebUser)
                    .IsRequired()
                    .HasMaxLength(201)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebSession>(entity =>
            {
                entity.HasKey(e => new { e.WebSessionId, e.StartDateTime });

                entity.ToTable("WebSession");

                entity.Property(e => e.WebSessionId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDuration).HasColumnType("numeric(17, 6)");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WebUserCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebSessionIdssrvsql>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WebSession_IDSSRVSQL");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDuration).HasColumnType("numeric(17, 6)");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WebSessionId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WebUserCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebSessionRpt>(entity =>
            {
                entity.HasKey(e => new { e.WebSessionId, e.StartDateTime });

                entity.ToTable("WebSessionRPT");

                entity.Property(e => e.WebSessionId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDuration).HasColumnType("numeric(17, 6)");

                entity.Property(e => e.StartDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WebUserCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebUser>(entity =>
            {
                entity.HasKey(e => e.WebUserCode);

                entity.ToTable("WebUser");

                entity.Property(e => e.WebUserCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CubePassword)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CubeUsername)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WebUserFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WebUserLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZWebuser20220314>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Z_WEBUSER_20220314");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("AGENT_CODE");

                entity.Property(e => e.Email)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.LastName)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Pin)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasColumnName("PIN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
