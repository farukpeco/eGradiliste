using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace eGradiliste.Database;

public partial class EGradilisteContext : DbContext
{
    public EGradilisteContext()
    {
    }

    public EGradilisteContext(DbContextOptions<EGradilisteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<JediniceMjere> JediniceMjeres { get; set; }

    public virtual DbSet<Korisnici> Korisnicis { get; set; }

    public virtual DbSet<KorisniciUloge> KorisniciUloges { get; set; }

    public virtual DbSet<Proizvodi> Proizvodis { get; set; }

    public virtual DbSet<Uloge> Uloges { get; set; }

    public virtual DbSet<VrsteProizvodum> VrsteProizvoda { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost, 1433;Initial Catalog=eGradiliste; User=sa; Password=test123!; Trusted_Connection=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JediniceMjere>(entity =>
        {
            entity.HasKey(e => e.JedinicaMjereId);

            entity.ToTable("JediniceMjere");
        });

        modelBuilder.Entity<Korisnici>(entity =>
        {
            entity.HasKey(e => e.KorisnikId);

            entity.ToTable("Korisnici");
        });

        modelBuilder.Entity<KorisniciUloge>(entity =>
        {
            entity.HasKey(e => e.KorisnikUlogaId);

            entity.ToTable("KorisniciUloge");

            entity.HasIndex(e => e.KorisniciKorisnikId, "IX_KorisniciUloge_KorisniciKorisnikId");

            entity.HasIndex(e => e.UlogaId, "IX_KorisniciUloge_UlogaId");

            entity.HasOne(d => d.KorisniciKorisnik).WithMany(p => p.KorisniciUloges).HasForeignKey(d => d.KorisniciKorisnikId);

            entity.HasOne(d => d.Uloga).WithMany(p => p.KorisniciUloges).HasForeignKey(d => d.UlogaId);
        });

        modelBuilder.Entity<Proizvodi>(entity =>
        {
            entity.ToTable("Proizvodi");

            entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Uloge>(entity =>
        {
            entity.HasKey(e => e.UlogaId);

            entity.ToTable("Uloge");
        });

        modelBuilder.Entity<VrsteProizvodum>(entity =>
        {
            entity.HasKey(e => e.VrstaId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
