using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APITiendaDeRopaOnline.Models;

public partial class TiendaonlineContext : DbContext
{
    public TiendaonlineContext()
    {
    }

    public TiendaonlineContext(DbContextOptions<TiendaonlineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Talla> Tallas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__PRODUCTO__098892108CFCC897");

            entity.ToTable("PRODUCTO");

            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.objectTalla).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdTalla)
                .HasConstraintName("FK_IDTALLA");
        });

        modelBuilder.Entity<Talla>(entity =>
        {
            entity.HasKey(e => e.IdTalla).HasName("PK__TALLA__E95BE943BD7C6AE8");

            entity.ToTable("TALLA");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
