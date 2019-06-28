using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LL.Web.Models
{
    public partial class AB_Prabha_DBContext : DbContext
    {
        public AB_Prabha_DBContext()
        {
        }

        public AB_Prabha_DBContext(DbContextOptions<AB_Prabha_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AmSessionTbl> AmSessionTbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=amritaprabha.database.windows.net;Database=AB_Prabha_DB;user id=amuser;password=vfBb9SztsA$pIwy3;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AmSessionTbl>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("AM_SessionTBL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .IsRowVersion();
            });
        }
    }
}
