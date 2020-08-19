using System;
using ERP.Auth;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ERP.Models
{
    public partial class ERPContext : IdentityDbContext<ApplicationUser>
    {
       
        public ERPContext(DbContextOptions<ERPContext> options)
            : base(options)
        {
        }

        public  DbSet<AccAccount> AccAccount { get; set; }
        public  DbSet<AccJournal> AccJournal { get; set; }
        public  DbSet<AccJournalDetail> AccJournalDetail { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AccAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("ACC_Account");

                entity.Property(e => e.AcNumber)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Budget).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.OldName).HasMaxLength(50);
            });

            modelBuilder.Entity<AccJournal>(entity =>
            {
                entity.HasKey(e => e.JournalId);

                entity.ToTable("ACC_Journal");

                entity.Property(e => e.CrncRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.Jcode).HasColumnName("JCode");

                entity.Property(e => e.Jnotes).HasColumnName("JNotes");

                entity.Property(e => e.Jnumber)
                    .HasColumnName("JNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AccJournalDetail>(entity =>
            {
                entity.HasKey(e => e.JdetailId);

                entity.ToTable("ACC_JournalDetail");

                entity.Property(e => e.JdetailId).HasColumnName("JDetailId");

                entity.Property(e => e.Credit).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.CrncRate).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.Debit).HasColumnType("decimal(20, 6)");

                entity.Property(e => e.DueDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
