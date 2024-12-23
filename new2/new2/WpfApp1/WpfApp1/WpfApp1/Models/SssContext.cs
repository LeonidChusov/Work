using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WpfApp1.Models;

public partial class SssContext : DbContext
{
    public SssContext()
    {
    }

    public SssContext(DbContextOptions<SssContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dan> Dans { get; set; }

    public virtual DbSet<Prodavez> Prodavezs { get; set; }

    public virtual DbSet<Regestrat> Regestrats { get; set; }

    public virtual DbSet<Roomim> Roomims { get; set; }

    public virtual DbSet<Usersss> Userssses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("DataSource=C:\\Users\\Лёня\\Desktop\\new2\\new2\\WpfApp1\\WpfApp1\\WpfApp1\\sss.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dan>(entity =>
        {
            entity.HasKey(e => e.IdDan);

            entity.ToTable("Dan");

            entity.HasIndex(e => e.IdDan, "IX_Dan_id_dan").IsUnique();

            entity.Property(e => e.IdDan).HasColumnName("id_dan");
            entity.Property(e => e.Adreess).HasColumnName("adreess");
            entity.Property(e => e.FlootKom).HasColumnName("floot_kom");
            entity.Property(e => e.Imagge).HasColumnName("imagge");
            entity.Property(e => e.Ittag).HasColumnName("ittag");
            entity.Property(e => e.Metr).HasColumnName("metr");
            entity.Property(e => e.Price).HasColumnName("price");
        });

        modelBuilder.Entity<Prodavez>(entity =>
        {
            entity.ToTable("Prodavez");

            entity.HasIndex(e => e.Id, "IX_Prodavez_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fio).HasColumnName("fio");
            entity.Property(e => e.Nomer).HasColumnName("nomer");
            entity.Property(e => e.Seria).HasColumnName("seria");
            entity.Property(e => e.Telefon).HasColumnName("telefon");
        });

        modelBuilder.Entity<Regestrat>(entity =>
        {
            entity.ToTable("Regestrat");

            entity.HasIndex(e => e.Id, "IX_Regestrat_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Password).HasColumnName("password");
        });

        modelBuilder.Entity<Roomim>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Roomims_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adreess).HasColumnName("adreess");
            entity.Property(e => e.FlootKom).HasColumnName("floot_kom");
            entity.Property(e => e.Imagge).HasColumnName("imagge");
            entity.Property(e => e.Ittag).HasColumnName("ittag");
            entity.Property(e => e.Metr).HasColumnName("metr");
            entity.Property(e => e.MictoRoiin).HasColumnName("mictoRoiin");
            entity.Property(e => e.Opisaninie).HasColumnName("opisaninie");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Remont).HasColumnName("remont");
            entity.Property(e => e.SrokVladenia).HasColumnName("srokVladenia");
        });

        modelBuilder.Entity<Usersss>(entity =>
        {
            entity.ToTable("Usersss");

            entity.HasIndex(e => e.Id, "IX_Usersss_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AdresNew).HasColumnName("adres_new");
            entity.Property(e => e.AdressReg).HasColumnName("adress_reg");
            entity.Property(e => e.Datarogden).HasColumnName("datarogden");
            entity.Property(e => e.Fio).HasColumnName("fio");
            entity.Property(e => e.KemVidan).HasColumnName("kem_vidan");
            entity.Property(e => e.NomerTelefon).HasColumnName("nomer_telefon");
            entity.Property(e => e.SreiaNomer).HasColumnName("sreia_nomer");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
