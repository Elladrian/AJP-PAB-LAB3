using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.Models;

public partial class Ajppablab3Context : DbContext
{
    public Ajppablab3Context()
    {
    }

    public Ajppablab3Context(DbContextOptions<Ajppablab3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<KodyPocztowe> KodyPocztowes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=GORWPC0008\\SQLDEVELOPER;Database=AJPPABLAB3;User ID=Administrator;Password=cisco123!L;TrustServerCertificate=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<KodyPocztowe>(entity =>
        {
            entity.ToTable("Kody_Pocztowe");

            entity.Property(e => e.Adres).HasColumnType("text");
            entity.Property(e => e.KodPocztowy)
                .HasColumnType("text")
                .HasColumnName("Kod_pocztowy");
            entity.Property(e => e.Miejscowosc).HasColumnType("text");
            entity.Property(e => e.Powiat).HasColumnType("text");
            entity.Property(e => e.Wojewodztwo).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
