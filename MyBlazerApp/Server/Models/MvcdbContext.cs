using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyBlazerApp.Server.Models
{
    public partial class MvcdbContext : DbContext
    {
        public MvcdbContext()
        {
        }

        public MvcdbContext(DbContextOptions<MvcdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tbemployee> Tbemployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress ;Initial Catalog=Mvcdb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbemployee>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("PK__tbemploy__AF4C318A892965E1");

                entity.ToTable("tbemployee");

                entity.Property(e => e.Empno)
                    .HasColumnName("empno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Eadd)
                    .HasColumnName("eadd")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Esal).HasColumnName("esal");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
