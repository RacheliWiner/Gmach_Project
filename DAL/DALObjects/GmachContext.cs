using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.DalObject;

public partial class GmachContext : DbContext
{
    public GmachContext(DbContextOptions<GmachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Classification> Classifications { get; set; }

    public virtual DbSet<Gmach> Gmaches { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<ProductRepo> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Classification>(entity =>
        {
            entity.HasKey(e => e.ClassificationId).HasName("PK__Classifi__93F59C96DA7496A8");

            entity.Property(e => e.ClassificationId)
                .ValueGeneratedNever()
                .HasColumnName("classificationId");
            entity.Property(e => e.ClassDescription)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Gmach>(entity =>
        {
            entity.HasKey(e => e.GmachCode).HasName("PK__Gmach__3732808E0F983625");

            entity.ToTable("Gmach");

            entity.Property(e => e.Email)
                .HasMaxLength(94)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.GmachName)
                .IsRequired()
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MaxTime)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.OpeningHours)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.WhatsApp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.ClassificationsNavigation).WithMany(p => p.Gmaches)
                .HasForeignKey(d => d.Classifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Gmach__Classific__5EBF139D");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.GmachCode).HasName("PK__Location__3732808EDE181D24");

            entity.Property(e => e.GmachCode).ValueGeneratedNever();
            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HouseNumber)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Neighborhood)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Street)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Zip)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.GmachCodeNavigation).WithOne(p => p.Location)
                .HasForeignKey<Location>(d => d.GmachCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_gmachcode");
        });

        modelBuilder.Entity<ProductRepo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Amount)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LeftInStock)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProductCode).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductDescription)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.GmachCodeNavigation).WithMany()
                .HasForeignKey(d => d.GmachCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GmachCodes");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
