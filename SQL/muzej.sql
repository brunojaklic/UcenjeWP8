use master;
go
drop database if exists muzej;
go
create database muzej;
go
use muzej;

create table kustosi(
sifra int not null primary key identity(1,1),
ime varchar(20) not null,
prezime varchar(20) not null
);

create table sponzori(
sifra int not null primary key identity(1,1),
naziv int not null
);

create table izlozbe(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
starost int,
kustos int references kustosi(sifra),
sponzor int references sponzori(sifra)
);

create table djela(
sifra int not null primary key identity(1,1),
naziv int not null,
izlozba int not null references izlozbe(sifra)
);

