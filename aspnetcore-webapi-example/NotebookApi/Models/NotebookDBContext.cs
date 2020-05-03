using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NotebookApi.Models
{
    public partial class NotebookDBContext : DbContext
    {
        public NotebookDBContext()
        {
        }

        public NotebookDBContext(DbContextOptions<NotebookDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblNotes> TblNotes { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("NotebookDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblNotes>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("tbl_notes");

                entity.Property(e => e.NoteId).HasColumnName("noteId");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_tbl_users_1");

                entity.ToTable("tbl_users");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasColumnName("userPassword")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
