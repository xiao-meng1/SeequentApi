using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SeequentApi.Models;

public partial class SeequentContext : DbContext
{
    public SeequentContext()
    {
    }

    public SeequentContext(DbContextOptions<SeequentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Borehole> Boreholes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=desktop-qupa03p;Database=Seequent;Trusted_Connection=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Borehole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Borehole__3214EC07462EA67E");

            entity.ToTable("Borehole");

            entity.Property(e => e.CableStrength).HasMaxLength(500);
            entity.Property(e => e.CableType).HasMaxLength(100);
            entity.Property(e => e.DrillStrength).HasMaxLength(500);
            entity.Property(e => e.DrillType).HasMaxLength(100);
            entity.Property(e => e.XlocationKm).HasColumnName("XLocationKm");
            entity.Property(e => e.YlocationKm).HasColumnName("YLocationKm");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
