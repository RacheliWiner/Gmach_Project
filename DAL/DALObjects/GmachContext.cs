using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.DALObjects;

public partial class GmachContext : DbContext
{
    public GmachContext(DbContextOptions<GmachContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Classification> Classifications { get; set; }

    public virtual DbSet<Gmach> Gmaches { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<OwnerPassword> OwnerPasswords { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Classification>(entity =>
        {
            entity.HasKey(e => e.ClassificationId).HasName("PK__Classifi__93F59C968C809DCE");

            entity.Property(e => e.ClassificationId)
                .ValueGeneratedNever()
                .HasColumnName("classificationId");
            entity.Property(e => e.ClassDescription)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("classDescription");
        });

        modelBuilder.Entity<Gmach>(entity =>
        {
            entity.HasKey(e => e.GmachCode).HasName("PK__Gmach__3C695C29080C8BB7");

            entity.ToTable("Gmach");

            entity.Property(e => e.GmachCode).HasColumnName("gmachCode");
            entity.Property(e => e.Classifications).HasColumnName("classifications");
            entity.Property(e => e.Email)
                .HasMaxLength(94)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("email");
            entity.Property(e => e.GmachName)
                .IsRequired()
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("gmachName");
            entity.Property(e => e.MaxTime)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("maxTime");
            entity.Property(e => e.OpeningHours)
                .HasMaxLength(1000)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("openingHours");
            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("phoneNumber");
            entity.Property(e => e.WhatsApp)
                .HasMaxLength(20)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("whatsApp");

            entity.HasOne(d => d.ClassificationsNavigation).WithMany(p => p.Gmaches)
                .HasForeignKey(d => d.Classifications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Gmach__classific__797309D9");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.GmachCode).HasName("PK__Location__3C695C2936CDA067");

            entity.Property(e => e.GmachCode)
                .ValueGeneratedNever()
                .HasColumnName("gmachCode");
            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("city");
            entity.Property(e => e.HouseNumber)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("houseNumber");
            entity.Property(e => e.Neighborhood)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("neighborhood");
            entity.Property(e => e.Street)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("street");
            entity.Property(e => e.Zip)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("zip");

            entity.HasOne(d => d.GmachCodeNavigation).WithOne(p => p.Location)
                .HasForeignKey<Location>(d => d.GmachCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Locations__gmach__7C4F7684");
        });

        modelBuilder.Entity<OwnerPassword>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OwnerPassword");

            entity.Property(e => e.OwnerPassword1)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("ownerPassword");

            entity.HasOne(d => d.GmachCodeNavigation).WithMany()
                .HasForeignKey(d => d.GmachCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OwnerPass__Gmach__00200768");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Amount)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("amount");
            entity.Property(e => e.GmachCode).HasColumnName("gmachCode");
            entity.Property(e => e.LeftInStock)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("leftInStock");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductCode)
                .ValueGeneratedOnAdd()
                .HasColumnName("productCode");
            entity.Property(e => e.ProductDescription)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("productDescription");
            entity.Property(e => e.ProductName)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("productName");

            entity.HasOne(d => d.GmachCodeNavigation).WithMany()
                .HasForeignKey(d => d.GmachCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Products__gmachC__7E37BEF6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
