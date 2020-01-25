using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SeminarskiRS1.Migrations
{
    public partial class Treca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "drzava",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drzava", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "popust",
                columns: table => new
                {
                    PopustID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    KolicinaPopusta = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_popust", x => x.PopustID);
                });

            migrationBuilder.CreateTable(
                name: "uposleniktip",
                columns: table => new
                {
                    UposlenikTipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uposleniktip", x => x.UposlenikTipId);
                });

            migrationBuilder.CreateTable(
                name: "vozilo",
                columns: table => new
                {
                    VoziloID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(nullable: true),
                    Marka = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    KS = table.Column<int>(nullable: false),
                    Potrosnja = table.Column<string>(nullable: true),
                    Registracija = table.Column<string>(nullable: true),
                    VazenjeRegistracije = table.Column<DateTime>(nullable: false),
                    Masa = table.Column<string>(nullable: true),
                    ZapreminaMotora = table.Column<string>(nullable: true),
                    GodinaProizvodnje = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vozilo", x => x.VoziloID);
                });

            migrationBuilder.CreateTable(
                name: "kanton",
                columns: table => new
                {
                    KantonID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKantonta = table.Column<string>(nullable: true),
                    Skracenica = table.Column<string>(nullable: true),
                    DrzavaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kanton", x => x.KantonID);
                    table.ForeignKey(
                        name: "FK_kanton_drzava_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "drzava",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "grad",
                columns: table => new
                {
                    GradID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    KantonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grad", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_grad_kanton_KantonID",
                        column: x => x.KantonID,
                        principalTable: "kanton",
                        principalColumn: "KantonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "adresa",
                columns: table => new
                {
                    AdresaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostanskiBroj = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: true),
                    BrojAdrese = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adresa", x => x.AdresaID);
                    table.ForeignKey(
                        name: "FK_adresa_grad_GradID",
                        column: x => x.GradID,
                        principalTable: "grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "enp",
                columns: table => new
                {
                    ENPID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    BrTelefona = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    RadnoVrijeme = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enp", x => x.ENPID);
                    table.ForeignKey(
                        name: "FK_enp_grad_GradID",
                        column: x => x.GradID,
                        principalTable: "grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "epunjaci",
                columns: table => new
                {
                    EPunjaciID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LokacijaMap = table.Column<string>(nullable: true),
                    LokacijaNaziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_epunjaci", x => x.EPunjaciID);
                    table.ForeignKey(
                        name: "FK_epunjaci_grad_GradID",
                        column: x => x.GradID,
                        principalTable: "grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "freewifi",
                columns: table => new
                {
                    WifiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LokacijaMap = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    PristupnaSifra = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_freewifi", x => x.WifiID);
                    table.ForeignKey(
                        name: "FK_freewifi_grad_GradID",
                        column: x => x.GradID,
                        principalTable: "grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "servis",
                columns: table => new
                {
                    ServisID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LokacijaMap = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    RadnoVrijeme = table.Column<string>(nullable: true),
                    Usluge = table.Column<string>(nullable: true),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servis", x => x.ServisID);
                    table.ForeignKey(
                        name: "FK_servis_grad_GradID",
                        column: x => x.GradID,
                        principalTable: "grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "uposlenik",
                columns: table => new
                {
                    UposlenikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    BrTelefona = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    UposlenikTipID = table.Column<int>(nullable: false),
                    GradID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uposlenik", x => x.UposlenikID);
                    table.ForeignKey(
                        name: "FK_uposlenik_grad_GradID",
                        column: x => x.GradID,
                        principalTable: "grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_uposlenik_uposleniktip_UposlenikTipID",
                        column: x => x.UposlenikTipID,
                        principalTable: "uposleniktip",
                        principalColumn: "UposlenikTipId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "korisnik",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    BrTelefona = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Spol = table.Column<string>(nullable: true),
                    VoziloID = table.Column<int>(nullable: false),
                    AdresaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnik", x => x.KorisnikID);
                    table.ForeignKey(
                        name: "FK_korisnik_adresa_AdresaID",
                        column: x => x.AdresaID,
                        principalTable: "adresa",
                        principalColumn: "AdresaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_korisnik_vozilo_VoziloID",
                        column: x => x.VoziloID,
                        principalTable: "vozilo",
                        principalColumn: "VoziloID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "obavijesti",
                columns: table => new
                {
                    ObavijestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(nullable: false),
                    Sadrzaj = table.Column<string>(nullable: true),
                    UposlenikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_obavijesti", x => x.ObavijestID);
                    table.ForeignKey(
                        name: "FK_obavijesti_uposlenik_UposlenikID",
                        column: x => x.UposlenikID,
                        principalTable: "uposlenik",
                        principalColumn: "UposlenikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "korisnickeporuke",
                columns: table => new
                {
                    KorisnickePorukeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sadrzaj = table.Column<string>(nullable: true),
                    KorisnikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_korisnickeporuke", x => x.KorisnickePorukeID);
                    table.ForeignKey(
                        name: "FK_korisnickeporuke_korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ruta",
                columns: table => new
                {
                    RutaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(nullable: true),
                    Pocetna = table.Column<string>(nullable: true),
                    Zavrsna = table.Column<string>(nullable: true),
                    Daljina = table.Column<string>(nullable: true),
                    CijenaPutarine = table.Column<string>(nullable: true),
                    KorisnikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ruta", x => x.RutaID);
                    table.ForeignKey(
                        name: "FK_ruta_korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "korisnik",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_adresa_GradID",
                table: "adresa",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_enp_GradID",
                table: "enp",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_epunjaci_GradID",
                table: "epunjaci",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_freewifi_GradID",
                table: "freewifi",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_grad_KantonID",
                table: "grad",
                column: "KantonID");

            migrationBuilder.CreateIndex(
                name: "IX_kanton_DrzavaID",
                table: "kanton",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_korisnickeporuke_KorisnikID",
                table: "korisnickeporuke",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_korisnik_AdresaID",
                table: "korisnik",
                column: "AdresaID");

            migrationBuilder.CreateIndex(
                name: "IX_korisnik_VoziloID",
                table: "korisnik",
                column: "VoziloID");

            migrationBuilder.CreateIndex(
                name: "IX_obavijesti_UposlenikID",
                table: "obavijesti",
                column: "UposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_ruta_KorisnikID",
                table: "ruta",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_servis_GradID",
                table: "servis",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_uposlenik_GradID",
                table: "uposlenik",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_uposlenik_UposlenikTipID",
                table: "uposlenik",
                column: "UposlenikTipID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enp");

            migrationBuilder.DropTable(
                name: "epunjaci");

            migrationBuilder.DropTable(
                name: "freewifi");

            migrationBuilder.DropTable(
                name: "korisnickeporuke");

            migrationBuilder.DropTable(
                name: "obavijesti");

            migrationBuilder.DropTable(
                name: "popust");

            migrationBuilder.DropTable(
                name: "ruta");

            migrationBuilder.DropTable(
                name: "servis");

            migrationBuilder.DropTable(
                name: "uposlenik");

            migrationBuilder.DropTable(
                name: "korisnik");

            migrationBuilder.DropTable(
                name: "uposleniktip");

            migrationBuilder.DropTable(
                name: "adresa");

            migrationBuilder.DropTable(
                name: "vozilo");

            migrationBuilder.DropTable(
                name: "grad");

            migrationBuilder.DropTable(
                name: "kanton");

            migrationBuilder.DropTable(
                name: "drzava");
        }
    }
}
