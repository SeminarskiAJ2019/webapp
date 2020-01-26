CREATE DATABASE JPAutoceste
GO
USE JPAutoceste
GO

CREATE TABLE Drzava
(
	DrzavaID INT NOT NULL,
	Naziv NVARCHAR (40) NULL,
	CONSTRAINT PK_Drzava PRIMARY KEY (DrzavaID)
)

CREATE TABLE Kanton
(
	KantonID INT NOT NULL,
	DrzavaID INT NULL,
	NazivKantona NVARCHAR(30) NULL,
	Skracenica NVARCHAR (3) NULL,
	CONSTRAINT FK_Kanton_Drzava FOREIGN KEY (DrzavaID) REFERENCES Drzava (DrzavaID),
	CONSTRAINT PK_Kanton PRIMARY KEY (KantonID)
)

CREATE TABLE Grad
(
	GradID INT NOT NULL,
	KantonID INT NULL,
	DrzavaID INT NULL,
	Naziv NVARCHAR (40) NULL,
	CONSTRAINT FK_Grad_Kanton FOREIGN KEY (KantonID) REFERENCES Kanton (KantonID),
	CONSTRAINT FK_Grad_Drzava FOREIGN KEY (DrzavaID) REFERENCES Drzava (DrzavaID),
	CONSTRAINT PK_Grad PRIMARY KEY (GradID)

)

CREATE TABLE UposlenikTip
(
	UposlenikTipID INT NOT NULL,
	Naziv NVARCHAR (30) NULL,
	CONSTRAINT PK_Uposlenik_tip PRIMARY KEY (UposlenikTipID)
)

CREATE TABLE Uposlenik
(
	UposlenikID INT NOT NULL,
	UposlenikTipID INT NULL,
	GradID INT NULL,
	Ime NVARCHAR (30) NULL,
	Prezime NVARCHAR (30) NULL,
	Br_telefona NVARCHAR (50) NULL,
	Email NVARCHAR (100) NULL,
	Spol NVARCHAR (1) NULL CHECK (Spol IN ('M', 'F')),
	CONSTRAINT FK_Tip_Uposlenika FOREIGN KEY (UposlenikTipID) REFERENCES UposlenikTip(UposlenikTipID),
	CONSTRAINT FK_Grad_Uposlenika FOREIGN KEY (GradID) REFERENCES Grad(GradID),
	CONSTRAINT PK_Uposlenik PRIMARY KEY (UposlenikID)
)

/*
UposlenikID je autor obavijesti.
*/

CREATE TABLE Obavijesti
(
	ObavijestID INT NOT NULL,
	UposlenikID INT NULL,
	Datum DATE NULL,
	Sadrzaj NVARCHAR (140) NULL,
	CONSTRAINT FK_Obavijesti_Autor FOREIGN KEY (UposlenikID) REFERENCES Uposlenik(UposlenikID),
	CONSTRAINT PK_Obavijesti PRIMARY KEY (ObavijestID)

)

CREATE TABLE Adresa
(
	AdresaID INT NOT NULL,
	GradID INT NULL,
	PostanskiBroj INT NULL,
	Naziv NVARCHAR (30) NULL,
	BrojAdrese NVARCHAR(10) NULL,
	CONSTRAINT FK_Grad_Adresa FOREIGN KEY (GradID) REFERENCES Grad (GradID),
	Constraint PK_Adresa PRIMARY KEY (AdresaID)
)


CREATE TABLE ENP
(
	ENPID INT NOT NULL,
	GradID INT NOT NULL,
	Naziv NVARCHAR (40),
	Br_telefona NVARCHAR (50) NULL,
	Email NVARCHAR (100) NULL,
	RadnoVrijeme NVARCHAR (20),
	CONSTRAINT FK_ENP_Grad FOREIGN KEY (GradID) REFERENCES Grad(GradID),
	CONSTRAINT PK_ENP PRIMARY KEY (ENPID)
)





CREATE TABLE Vozilo
(
	VoziloID INT NOT NULL,
	Tip NVARCHAR (40) NULL,
	Marka NVARCHAR (40) NULL,
	Model  NVARCHAR (40) NULL,
	KS INT NULL,
	Potrosnja NVARCHAR (40) NULL,
	Registracija NVARCHAR (40) NULL,
	VazenjeRegistracije DATE NULL,
	Masa NVARCHAR (40) NULL,
	ZapreminaMotora NVARCHAR (40) NULL,
	GodinaProizvodnje SMALLINT NULL,
	CONSTRAINT PK_Vozilo PRIMARY KEY (VoziloID)

)
CREATE TABLE Popust
(
	PopustID INT NOT NULL,
	Naziv NVARCHAR (40) NULL,
	KolicinaPopusta SMALLINT NULL,
	CONSTRAINT PK_Popust PRIMARY KEY (PopustID)

)
CREATE TABLE Korisnici
(
	KorisnikID INT NOT NULL,
	VoziloID INT NULL,
	AdresaID INT NULL,
	PopustID INT NULL,
	Ime NVARCHAR (30) NULL,
	Prezime NVARCHAR (30) NULL,
	Br_telefona NVARCHAR (50) NULL,
	Email NVARCHAR (100) NULL,
	Spol NVARCHAR (1) NULL CHECK (Spol IN ('M', 'F')),
	CONSTRAINT FK_Korisnik_Vozilo FOREIGN KEY (VoziloID) REFERENCES Vozilo(VoziloID),
	CONSTRAINT FK_Korisnik_Adresa FOREIGN KEY (AdresaID) REFERENCES Adresa(AdresaID),
	CONSTRAINT FK_Korisnik_Popust FOREIGN KEY (PopustID) REFERENCES Popust(PopustID),
	CONSTRAINT PK_Korisnik PRIMARY KEY (KorisnikID)
)

CREATE TABLE KorisnickePoruke
(
	KorisnickePorukeID INT NOT NULL,
	KorisnikID INT NOT NULL,
	Sadrzaj NVARCHAR (1000) NULL,
	CONSTRAINT FK_KorisnickePoruke_Korisnik FOREIGN KEY (KorisnikID) REFERENCES Korisnici(KorisnikID),
	CONSTRAINT PK_KorisnickePoruke PRIMARY KEY (KorisnickePorukeID)
)

CREATE TABLE Ruta
(
	RutaID INT NOT NULL,
	KorisnikID INT NULL,
	Naziv NVARCHAR (40) NULL,
	Pocetna NVARCHAR (80) NULL,
	Zavrsna NVARCHAR (40) NULL,
	Daljina NVARCHAR (40) NULL,
	CijenaPutarine MONEY NULL,
	CONSTRAINT FK_RutaKorisnik FOREIGN KEY (KorisnikID) REFERENCES Korisnici(KorisnikID),
	CONSTRAINT PK_Ruta PRIMARY KEY (RutaID)
)

/*
LokacijaMap nisam siguran da treba biti nvarchar tj. string iz razloga što bi tu vjerovatno bile koordinate ili neki kod koji bi nam googlemaps API poslao,
ali ostavio bi ovako dok ne znamo
*/
CREATE TABLE EPunjaci
(
	EPunjaciID INT NOT NULL,
	GradID INT NOT NULL,
	LokacijaMap NVARCHAR (40) NULL,
	LokacijaNaziv NVARCHAR (40) NULL,
	Opis NVARCHAR (200) NULL,
	CONSTRAINT FK_Grad_EPunjaci FOREIGN KEY (GradID) REFERENCES Grad(GradID),
	CONSTRAINT PK_EPunjac PRIMARY KEY (EPunjaciID)
)
/*
LokacijaMap važi isto kao i prethodnoj tabeli.
*/
CREATE TABLE FreeWiFi
(
	WifiID INT NOT NULL,
	GradID INT NULL,
	LokacijaMap NVARCHAR (40) NULL,
	Opis NVARCHAR (100) NULL,
	PristupnaSifra NVARCHAR (40) NULL,
	CONSTRAINT FK_Grad_Wifi FOREIGN KEY (GradID) REFERENCES Grad(GradID),
	CONSTRAINT PK_FreeWifi PRIMARY KEY (WifiID)
)


CREATE TABLE Servis
(
	ServisID INT NOT NULL,
	GradID INT NOT NULL,
	LokacijaMap NVARCHAR (40) NULL,
	Opis NVARCHAR (100) NULL,
	RadnoVrijeme NVARCHAR (20),
	Usluge NVARCHAR (1000),
	CONSTRAINT FK_Grad_Servis FOREIGN KEY (GradID) REFERENCES Grad(GradID),
	CONSTRAINT PK_Servis PRIMARY KEY (ServisID)
)

/*
CREATE TABLE PopustTip
(
)
*/