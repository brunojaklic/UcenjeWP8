use master;
go
drop database if exists vrtic;
go
create database vrtic;
go
use vrtic;

create table strucne_spreme(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null
);

create table odgajateljice(
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(20) not null,
strucna_sprema int references strucne_spreme(sifra)
);

create table skupine(
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
odgajateljica int references odgajateljice(sifra)
);

create table djeca(
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(20) not null,
skupina int references skupine(sifra)
);