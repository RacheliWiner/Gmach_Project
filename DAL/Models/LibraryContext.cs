using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Classification> Classifications { get; set; }

    public virtual DbSet<Gmach> Gmaches { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Classification>(entity =>
        {
            entity.HasKey(e => e.Classifications).HasName("PK__Classifi__191357387CCCDAE4");

            entity.Property(e => e.Classifications).HasMaxLength(50);
        });

        modelBuilder.Entity<Gmach>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Gmach");

            entity.Property(e => e.Classifications).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(94);
            entity.Property(e => e.GmachCode).ValueGeneratedOnAdd();
            entity.Property(e => e.GmachName).HasMaxLength(100);
            entity.Property(e => e.MaxTime).HasMaxLength(50);
            entity.Property(e => e.OpeningHours).HasMaxLength(1000);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.WhatsApp).HasMaxLength(20);
            entity.Property(e => e.Zip).HasMaxLength(50);

            entity.HasOne(d => d.ClassificationsNavigation).WithMany()
                .HasForeignKey(d => d.Classifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Classifications");

            entity.HasOne(d => d.GmachCodeNavigation).WithMany()
                .HasForeignKey(d => d.GmachCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GmachCodes");

            entity.HasOne(d => d.ZipNavigation).WithMany()
                .HasForeignKey(d => d.Zip)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Zip");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Zip).HasName("PK__Location__D8F67F7E15EA689B");

            entity.Property(e => e.Zip).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.HouseNumber).HasMaxLength(50);
            entity.Property(e => e.Neighborhood).HasMaxLength(50);
            entity.Property(e => e.Street).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.GmachCode).HasName("PK__Products__3732808E8EB303C7");

            entity.Property(e => e.GmachCode).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasMaxLength(50);
            entity.Property(e => e.LeftInStock).HasMaxLength(50);
            entity.Property(e => e.ProductCode).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductDescription).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
