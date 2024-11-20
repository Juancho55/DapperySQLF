using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFreamworkBD.Models;

public partial class RedarborContext : DbContext
{
    public RedarborContext()
    {
    }

    public RedarborContext(DbContextOptions<RedarborContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-QHNP2HL\\SQLEXPRESS;Database=REDARBOR;User ID=sa;Password=Fenix2121@; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.CreateOn).HasColumnType("datetime");
            entity.Property(e => e.DeleteOn).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.Fax)
                .HasMaxLength(15)
                .HasColumnName("FAX");
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Passwrod).HasColumnType("ntext");
            entity.Property(e => e.Telephone).HasMaxLength(15);
            entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
