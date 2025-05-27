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

insert into programi (naziv, cijena, aktivan) values
('Fitness početni', 30.00, 1),    
('Kondicijski trening', 45.00, 1),
('Napredna snaga', 60.00, 0); 

insert into kategorije (naziv, cijena) values
('Student', 20.00),
('Odrasli', 40.00),
('Seniori', 25.00);

insert into grupe (naziv, program, trener) values
('FP1', 1, 'Ivan Ivić'),
('KT1', 2, 'Ana Anić'),
('NS1', 3, 'Marko Marić');

insert into vjezbaci (ime, prezime, email, kategorija) values
('Luka', 'Horvat', 'luka.horvat@example.com', 1),
('Ivana', 'Babić', 'ivana.babic@example.com', 2),
('Marko', 'Novak', 'marko.novak@example.com', 2),
('Marija', 'Kovač', 'marija.kovac@example.com', 3);

insert into clanovi (grupa, vjezbac) values
(1, 1),
(2, 2),
(2, 3),
(3, 4);