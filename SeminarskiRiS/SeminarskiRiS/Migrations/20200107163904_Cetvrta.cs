using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiRS1.Migrations
{
    public partial class Cetvrta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_adresa_grad_GradID",
                table: "adresa");

            migrationBuilder.DropForeignKey(
                name: "FK_enp_grad_GradID",
                table: "enp");

            migrationBuilder.DropForeignKey(
                name: "FK_epunjaci_grad_GradID",
                table: "epunjaci");

            migrationBuilder.DropForeignKey(
                name: "FK_freewifi_grad_GradID",
                table: "freewifi");

            migrationBuilder.DropForeignKey(
                name: "FK_grad_kanton_KantonID",
                table: "grad");

            migrationBuilder.DropForeignKey(
                name: "FK_kanton_drzava_DrzavaID",
                table: "kanton");

            migrationBuilder.DropForeignKey(
                name: "FK_korisnickeporuke_korisnik_KorisnikID",
                table: "korisnickeporuke");

            migrationBuilder.DropForeignKey(
                name: "FK_korisnik_adresa_AdresaID",
                table: "korisnik");

            migrationBuilder.DropForeignKey(
                name: "FK_korisnik_vozilo_VoziloID",
                table: "korisnik");

            migrationBuilder.DropForeignKey(
                name: "FK_obavijesti_uposlenik_UposlenikID",
                table: "obavijesti");

            migrationBuilder.DropForeignKey(
                name: "FK_ruta_korisnik_KorisnikID",
                table: "ruta");

            migrationBuilder.DropForeignKey(
                name: "FK_servis_grad_GradID",
                table: "servis");

            migrationBuilder.DropForeignKey(
                name: "FK_uposlenik_grad_GradID",
                table: "uposlenik");

            migrationBuilder.DropForeignKey(
                name: "FK_uposlenik_uposleniktip_UposlenikTipID",
                table: "uposlenik");

            migrationBuilder.DropPrimaryKey(
                name: "PK_obavijesti",
                table: "obavijesti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_korisnickeporuke",
                table: "korisnickeporuke");

            migrationBuilder.DropPrimaryKey(
                name: "PK_freewifi",
                table: "freewifi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_epunjaci",
                table: "epunjaci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vozilo",
                table: "vozilo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_uposleniktip",
                table: "uposleniktip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_uposlenik",
                table: "uposlenik");

            migrationBuilder.DropPrimaryKey(
                name: "PK_servis",
                table: "servis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ruta",
                table: "ruta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_popust",
                table: "popust");

            migrationBuilder.DropPrimaryKey(
                name: "PK_korisnik",
                table: "korisnik");

            migrationBuilder.DropPrimaryKey(
                name: "PK_kanton",
                table: "kanton");

            migrationBuilder.DropPrimaryKey(
                name: "PK_grad",
                table: "grad");

            migrationBuilder.DropPrimaryKey(
                name: "PK_enp",
                table: "enp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drzava",
                table: "drzava");

            migrationBuilder.DropPrimaryKey(
                name: "PK_adresa",
                table: "adresa");

            migrationBuilder.RenameTable(
                name: "obavijesti",
                newName: "Obavijesti");

            migrationBuilder.RenameTable(
                name: "korisnickeporuke",
                newName: "Korisnickeporuke");

            migrationBuilder.RenameTable(
                name: "freewifi",
                newName: "Freewifi");

            migrationBuilder.RenameTable(
                name: "epunjaci",
                newName: "Epunjaci");

            migrationBuilder.RenameTable(
                name: "vozilo",
                newName: "Vozila");

            migrationBuilder.RenameTable(
                name: "uposleniktip",
                newName: "UposlenikTipovi");

            migrationBuilder.RenameTable(
                name: "uposlenik",
                newName: "Uposlenici");

            migrationBuilder.RenameTable(
                name: "servis",
                newName: "Servisi");

            migrationBuilder.RenameTable(
                name: "ruta",
                newName: "Rute");

            migrationBuilder.RenameTable(
                name: "popust",
                newName: "Popusti");

            migrationBuilder.RenameTable(
                name: "korisnik",
                newName: "Korisnici");

            migrationBuilder.RenameTable(
                name: "kanton",
                newName: "Kantoni");

            migrationBuilder.RenameTable(
                name: "grad",
                newName: "Gradovi");

            migrationBuilder.RenameTable(
                name: "enp",
                newName: "Enpovi");

            migrationBuilder.RenameTable(
                name: "drzava",
                newName: "Drzave");

            migrationBuilder.RenameTable(
                name: "adresa",
                newName: "Adrese");

            migrationBuilder.RenameIndex(
                name: "IX_obavijesti_UposlenikID",
                table: "Obavijesti",
                newName: "IX_Obavijesti_UposlenikID");

            migrationBuilder.RenameIndex(
                name: "IX_korisnickeporuke_KorisnikID",
                table: "Korisnickeporuke",
                newName: "IX_Korisnickeporuke_KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_freewifi_GradID",
                table: "Freewifi",
                newName: "IX_Freewifi_GradID");

            migrationBuilder.RenameIndex(
                name: "IX_epunjaci_GradID",
                table: "Epunjaci",
                newName: "IX_Epunjaci_GradID");

            migrationBuilder.RenameIndex(
                name: "IX_uposlenik_UposlenikTipID",
                table: "Uposlenici",
                newName: "IX_Uposlenici_UposlenikTipID");

            migrationBuilder.RenameIndex(
                name: "IX_uposlenik_GradID",
                table: "Uposlenici",
                newName: "IX_Uposlenici_GradID");

            migrationBuilder.RenameIndex(
                name: "IX_servis_GradID",
                table: "Servisi",
                newName: "IX_Servisi_GradID");

            migrationBuilder.RenameIndex(
                name: "IX_ruta_KorisnikID",
                table: "Rute",
                newName: "IX_Rute_KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_korisnik_VoziloID",
                table: "Korisnici",
                newName: "IX_Korisnici_VoziloID");

            migrationBuilder.RenameIndex(
                name: "IX_korisnik_AdresaID",
                table: "Korisnici",
                newName: "IX_Korisnici_AdresaID");

            migrationBuilder.RenameIndex(
                name: "IX_kanton_DrzavaID",
                table: "Kantoni",
                newName: "IX_Kantoni_DrzavaID");

            migrationBuilder.RenameIndex(
                name: "IX_grad_KantonID",
                table: "Gradovi",
                newName: "IX_Gradovi_KantonID");

            migrationBuilder.RenameIndex(
                name: "IX_enp_GradID",
                table: "Enpovi",
                newName: "IX_Enpovi_GradID");

            migrationBuilder.RenameIndex(
                name: "IX_adresa_GradID",
                table: "Adrese",
                newName: "IX_Adrese_GradID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Obavijesti",
                table: "Obavijesti",
                column: "ObavijestID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Korisnickeporuke",
                table: "Korisnickeporuke",
                column: "KorisnickePorukeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Freewifi",
                table: "Freewifi",
                column: "WifiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Epunjaci",
                table: "Epunjaci",
                column: "EPunjaciID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vozila",
                table: "Vozila",
                column: "VoziloID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UposlenikTipovi",
                table: "UposlenikTipovi",
                column: "UposlenikTipId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Uposlenici",
                table: "Uposlenici",
                column: "UposlenikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servisi",
                table: "Servisi",
                column: "ServisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rute",
                table: "Rute",
                column: "RutaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Popusti",
                table: "Popusti",
                column: "PopustID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Korisnici",
                table: "Korisnici",
                column: "KorisnikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kantoni",
                table: "Kantoni",
                column: "KantonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gradovi",
                table: "Gradovi",
                column: "GradID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enpovi",
                table: "Enpovi",
                column: "ENPID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drzave",
                table: "Drzave",
                column: "DrzavaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adrese",
                table: "Adrese",
                column: "AdresaID");

            migrationBuilder.CreateTable(
                name: "KorisnickiNalozi",
                columns: table => new
                {
                    KorisnickiNalogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    Lozinka = table.Column<byte[]>(nullable: true),
                    salt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiNalozi", x => x.KorisnickiNalogID);
                });

            migrationBuilder.CreateTable(
                name: "AutorizacijskiTokeni",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vrijednost = table.Column<string>(nullable: true),
                    KorisnickiNalogID = table.Column<int>(nullable: false),
                    VrijemeEvidentiranja = table.Column<DateTime>(nullable: false),
                    IpAdresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacijskiTokeni", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AutorizacijskiTokeni_KorisnickiNalozi_KorisnickiNalogID",
                        column: x => x.KorisnickiNalogID,
                        principalTable: "KorisnickiNalozi",
                        principalColumn: "KorisnickiNalogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacijskiTokeni_KorisnickiNalogID",
                table: "AutorizacijskiTokeni",
                column: "KorisnickiNalogID");

            migrationBuilder.AddForeignKey(
                name: "FK_Adrese_Gradovi_GradID",
                table: "Adrese",
                column: "GradID",
                principalTable: "Gradovi",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enpovi_Gradovi_GradID",
                table: "Enpovi",
                column: "GradID",
                principalTable: "Gradovi",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Epunjaci_Gradovi_GradID",
                table: "Epunjaci",
                column: "GradID",
                principalTable: "Gradovi",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Freewifi_Gradovi_GradID",
                table: "Freewifi",
                column: "GradID",
                principalTable: "Gradovi",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gradovi_Kantoni_KantonID",
                table: "Gradovi",
                column: "KantonID",
                principalTable: "Kantoni",
                principalColumn: "KantonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kantoni_Drzave_DrzavaID",
                table: "Kantoni",
                column: "DrzavaID",
                principalTable: "Drzave",
                principalColumn: "DrzavaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnici_Adrese_AdresaID",
                table: "Korisnici",
                column: "AdresaID",
                principalTable: "Adrese",
                principalColumn: "AdresaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnici_Vozila_VoziloID",
                table: "Korisnici",
                column: "VoziloID",
                principalTable: "Vozila",
                principalColumn: "VoziloID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Korisnickeporuke_Korisnici_KorisnikID",
                table: "Korisnickeporuke",
                column: "KorisnikID",
                principalTable: "Korisnici",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijesti_Uposlenici_UposlenikID",
                table: "Obavijesti",
                column: "UposlenikID",
                principalTable: "Uposlenici",
                principalColumn: "UposlenikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rute_Korisnici_KorisnikID",
                table: "Rute",
                column: "KorisnikID",
                principalTable: "Korisnici",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servisi_Gradovi_GradID",
                table: "Servisi",
                column: "GradID",
                principalTable: "Gradovi",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uposlenici_Gradovi_GradID",
                table: "Uposlenici",
                column: "GradID",
                principalTable: "Gradovi",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Uposlenici_UposlenikTipovi_UposlenikTipID",
                table: "Uposlenici",
                column: "UposlenikTipID",
                principalTable: "UposlenikTipovi",
                principalColumn: "UposlenikTipId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adrese_Gradovi_GradID",
                table: "Adrese");

            migrationBuilder.DropForeignKey(
                name: "FK_Enpovi_Gradovi_GradID",
                table: "Enpovi");

            migrationBuilder.DropForeignKey(
                name: "FK_Epunjaci_Gradovi_GradID",
                table: "Epunjaci");

            migrationBuilder.DropForeignKey(
                name: "FK_Freewifi_Gradovi_GradID",
                table: "Freewifi");

            migrationBuilder.DropForeignKey(
                name: "FK_Gradovi_Kantoni_KantonID",
                table: "Gradovi");

            migrationBuilder.DropForeignKey(
                name: "FK_Kantoni_Drzave_DrzavaID",
                table: "Kantoni");

            migrationBuilder.DropForeignKey(
                name: "FK_Korisnici_Adrese_AdresaID",
                table: "Korisnici");

            migrationBuilder.DropForeignKey(
                name: "FK_Korisnici_Vozila_VoziloID",
                table: "Korisnici");

            migrationBuilder.DropForeignKey(
                name: "FK_Korisnickeporuke_Korisnici_KorisnikID",
                table: "Korisnickeporuke");

            migrationBuilder.DropForeignKey(
                name: "FK_Obavijesti_Uposlenici_UposlenikID",
                table: "Obavijesti");

            migrationBuilder.DropForeignKey(
                name: "FK_Rute_Korisnici_KorisnikID",
                table: "Rute");

            migrationBuilder.DropForeignKey(
                name: "FK_Servisi_Gradovi_GradID",
                table: "Servisi");

            migrationBuilder.DropForeignKey(
                name: "FK_Uposlenici_Gradovi_GradID",
                table: "Uposlenici");

            migrationBuilder.DropForeignKey(
                name: "FK_Uposlenici_UposlenikTipovi_UposlenikTipID",
                table: "Uposlenici");

            migrationBuilder.DropTable(
                name: "AutorizacijskiTokeni");

            migrationBuilder.DropTable(
                name: "KorisnickiNalozi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Obavijesti",
                table: "Obavijesti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Korisnickeporuke",
                table: "Korisnickeporuke");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Freewifi",
                table: "Freewifi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Epunjaci",
                table: "Epunjaci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vozila",
                table: "Vozila");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UposlenikTipovi",
                table: "UposlenikTipovi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Uposlenici",
                table: "Uposlenici");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Servisi",
                table: "Servisi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rute",
                table: "Rute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Popusti",
                table: "Popusti");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Korisnici",
                table: "Korisnici");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kantoni",
                table: "Kantoni");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gradovi",
                table: "Gradovi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enpovi",
                table: "Enpovi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drzave",
                table: "Drzave");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adrese",
                table: "Adrese");

            migrationBuilder.RenameTable(
                name: "Obavijesti",
                newName: "obavijesti");

            migrationBuilder.RenameTable(
                name: "Korisnickeporuke",
                newName: "korisnickeporuke");

            migrationBuilder.RenameTable(
                name: "Freewifi",
                newName: "freewifi");

            migrationBuilder.RenameTable(
                name: "Epunjaci",
                newName: "epunjaci");

            migrationBuilder.RenameTable(
                name: "Vozila",
                newName: "vozilo");

            migrationBuilder.RenameTable(
                name: "UposlenikTipovi",
                newName: "uposleniktip");

            migrationBuilder.RenameTable(
                name: "Uposlenici",
                newName: "uposlenik");

            migrationBuilder.RenameTable(
                name: "Servisi",
                newName: "servis");

            migrationBuilder.RenameTable(
                name: "Rute",
                newName: "ruta");

            migrationBuilder.RenameTable(
                name: "Popusti",
                newName: "popust");

            migrationBuilder.RenameTable(
                name: "Korisnici",
                newName: "korisnik");

            migrationBuilder.RenameTable(
                name: "Kantoni",
                newName: "kanton");

            migrationBuilder.RenameTable(
                name: "Gradovi",
                newName: "grad");

            migrationBuilder.RenameTable(
                name: "Enpovi",
                newName: "enp");

            migrationBuilder.RenameTable(
                name: "Drzave",
                newName: "drzava");

            migrationBuilder.RenameTable(
                name: "Adrese",
                newName: "adresa");

            migrationBuilder.RenameIndex(
                name: "IX_Obavijesti_UposlenikID",
                table: "obavijesti",
                newName: "IX_obavijesti_UposlenikID");

            migrationBuilder.RenameIndex(
                name: "IX_Korisnickeporuke_KorisnikID",
                table: "korisnickeporuke",
                newName: "IX_korisnickeporuke_KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Freewifi_GradID",
                table: "freewifi",
                newName: "IX_freewifi_GradID");

            migrationBuilder.RenameIndex(
                name: "IX_Epunjaci_GradID",
                table: "epunjaci",
                newName: "IX_epunjaci_GradID");

            migrationBuilder.RenameIndex(
                name: "IX_Uposlenici_UposlenikTipID",
                table: "uposlenik",
                newName: "IX_uposlenik_UposlenikTipID");

            migrationBuilder.RenameIndex(
                name: "IX_Uposlenici_GradID",
                table: "uposlenik",
                newName: "IX_uposlenik_GradID");

            migrationBuilder.RenameIndex(
                name: "IX_Servisi_GradID",
                table: "servis",
                newName: "IX_servis_GradID");

            migrationBuilder.RenameIndex(
                name: "IX_Rute_KorisnikID",
                table: "ruta",
                newName: "IX_ruta_KorisnikID");

            migrationBuilder.RenameIndex(
                name: "IX_Korisnici_VoziloID",
                table: "korisnik",
                newName: "IX_korisnik_VoziloID");

            migrationBuilder.RenameIndex(
                name: "IX_Korisnici_AdresaID",
                table: "korisnik",
                newName: "IX_korisnik_AdresaID");

            migrationBuilder.RenameIndex(
                name: "IX_Kantoni_DrzavaID",
                table: "kanton",
                newName: "IX_kanton_DrzavaID");

            migrationBuilder.RenameIndex(
                name: "IX_Gradovi_KantonID",
                table: "grad",
                newName: "IX_grad_KantonID");

            migrationBuilder.RenameIndex(
                name: "IX_Enpovi_GradID",
                table: "enp",
                newName: "IX_enp_GradID");

            migrationBuilder.RenameIndex(
                name: "IX_Adrese_GradID",
                table: "adresa",
                newName: "IX_adresa_GradID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_obavijesti",
                table: "obavijesti",
                column: "ObavijestID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_korisnickeporuke",
                table: "korisnickeporuke",
                column: "KorisnickePorukeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_freewifi",
                table: "freewifi",
                column: "WifiID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_epunjaci",
                table: "epunjaci",
                column: "EPunjaciID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vozilo",
                table: "vozilo",
                column: "VoziloID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_uposleniktip",
                table: "uposleniktip",
                column: "UposlenikTipId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_uposlenik",
                table: "uposlenik",
                column: "UposlenikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_servis",
                table: "servis",
                column: "ServisID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ruta",
                table: "ruta",
                column: "RutaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_popust",
                table: "popust",
                column: "PopustID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_korisnik",
                table: "korisnik",
                column: "KorisnikID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_kanton",
                table: "kanton",
                column: "KantonID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_grad",
                table: "grad",
                column: "GradID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enp",
                table: "enp",
                column: "ENPID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_drzava",
                table: "drzava",
                column: "DrzavaID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_adresa",
                table: "adresa",
                column: "AdresaID");

            migrationBuilder.AddForeignKey(
                name: "FK_adresa_grad_GradID",
                table: "adresa",
                column: "GradID",
                principalTable: "grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_enp_grad_GradID",
                table: "enp",
                column: "GradID",
                principalTable: "grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_epunjaci_grad_GradID",
                table: "epunjaci",
                column: "GradID",
                principalTable: "grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_freewifi_grad_GradID",
                table: "freewifi",
                column: "GradID",
                principalTable: "grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_grad_kanton_KantonID",
                table: "grad",
                column: "KantonID",
                principalTable: "kanton",
                principalColumn: "KantonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_kanton_drzava_DrzavaID",
                table: "kanton",
                column: "DrzavaID",
                principalTable: "drzava",
                principalColumn: "DrzavaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_korisnickeporuke_korisnik_KorisnikID",
                table: "korisnickeporuke",
                column: "KorisnikID",
                principalTable: "korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_korisnik_adresa_AdresaID",
                table: "korisnik",
                column: "AdresaID",
                principalTable: "adresa",
                principalColumn: "AdresaID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_korisnik_vozilo_VoziloID",
                table: "korisnik",
                column: "VoziloID",
                principalTable: "vozilo",
                principalColumn: "VoziloID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_obavijesti_uposlenik_UposlenikID",
                table: "obavijesti",
                column: "UposlenikID",
                principalTable: "uposlenik",
                principalColumn: "UposlenikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ruta_korisnik_KorisnikID",
                table: "ruta",
                column: "KorisnikID",
                principalTable: "korisnik",
                principalColumn: "KorisnikID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_servis_grad_GradID",
                table: "servis",
                column: "GradID",
                principalTable: "grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_uposlenik_grad_GradID",
                table: "uposlenik",
                column: "GradID",
                principalTable: "grad",
                principalColumn: "GradID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_uposlenik_uposleniktip_UposlenikTipID",
                table: "uposlenik",
                column: "UposlenikTipID",
                principalTable: "uposleniktip",
                principalColumn: "UposlenikTipId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
