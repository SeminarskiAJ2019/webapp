using Microsoft.EntityFrameworkCore;
using SeminarskiRS1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class MojDbContext: DbContext
    {
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<ENP> Enpovi { get; set; }
        public DbSet<EPunjaci> Epunjaci { get; set; }
        public DbSet<FreeWifi> Freewifi { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Kanton> Kantoni { get; set; }
        public DbSet<KorisnickePoruke> Korisnickeporuke { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Obavijesti> Obavijesti { get; set; }
        public DbSet<Ruta> Rute { get; set; }
        public DbSet<Uposlenik> Uposlenici{ get; set; }
        public DbSet<UposlenikTip> UposlenikTipovi { get; set; }
        public DbSet<Vozilo> Vozila { get; set; }
        public DbSet<Popust> Popusti { get; set; }
        public DbSet<Servis> Servisi { get; set; }
        public DbSet<KorisnickiNalog> KorisnickiNalozi { get; set; }
        public DbSet<AutorizacijskiToken> AutorizacijskiTokeni { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;
                                                        Database=Seminarskipt2;
                                                        Trusted_Connection=True;
                                                        MultipleActiveResultSets=true;");
        }
    }
}
