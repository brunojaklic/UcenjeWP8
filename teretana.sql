use master;
go
drop database if exists teretana;
go
create database teretana collate Croatian_CI_AS;
go
use teretana;

create table programi(
	sifra int not null primary key identity(1,1),
	naziv varchar(50) not null,
	cijena decimal(18,2),
	aktivan bit not null
);

create table grupe(
	sifra int not null primary key identity(1,1),
	naziv varchar(50) not null,
	program int not null references programi(sifra),
	trener varchar(50) not null
);

create table kategorije(
	sifra int not null primary key identity(1,1),
	naziv varchar(50) not null,
	cijena decimal(18,2)
);

create table vjezbaci(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null,
	email varchar(50),
	kategorija int not null references kategorije(sifra)
);

create table clanovi(
	grupa int not null references grupe(sifra),
	vjezbac int not null references vjezbaci(sifra),
);
