using eGradiliste.eGradiliste.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace eGradiliste.eGradiliste.Services.Database;

public partial class eGradilisteContext : DbContext
{
    public eGradilisteContext()
    {
    }
    public eGradilisteContext(DbContextOptions<eGradilisteContext> options) : base(options)
    {
    }
    public DbSet<JediniceMjere> JediniceMjere { get; set; }
    public DbSet<Korisnici> Korisnici { get; set; }
    public DbSet<KorisniciUloge> KorisniciUloge { get; set; }
    public DbSet<Proizvodi> Proizvodi { get; set; }
    public DbSet<Uloge> Uloge { get; set; }
    public DbSet<VrsteProizvoda> VrsteProizvoda { get; set; }
}
