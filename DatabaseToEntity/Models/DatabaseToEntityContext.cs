using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseToEntity.Models;

public partial class DatabaseToEntityContext : DbContext
{
    public DatabaseToEntityContext()
    {
    }

    public DatabaseToEntityContext(DbContextOptions<DatabaseToEntityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DatabaseToEntity;trusted_connection=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity
                
                .ToTable("Student")
                .HasKey(e=>e.Id);

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.SirName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
