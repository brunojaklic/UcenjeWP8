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

-- Unos podataka u tablicu programi
INSERT INTO programi (naziv, cijena, aktivan) VALUES
('Total Body Workout', 300.00, 1),
('Yoga & Pilates', 250.00, 1),
('CrossFit Intenzivni', 400.00, 1),
('Kardio Fit', 200.00, 0), -- Neaktivan program
('Snaga & Izdržljivost', 350.00, 1),
('Funkcionalni Trening', 320.00, 1),
('Jutarnje Istezanje', 150.00, 1);

-- Unos podataka u tablicu kategorije (reducirano)
INSERT INTO kategorije (naziv, cijena) VALUES
('Student', 200.00),    -- Sifra će biti 1
('Standard', 300.00),   -- Sifra će biti 2
('Senior', 180.00);     -- Sifra će biti 3

-- Unos podataka u tablicu grupe
-- Pretpostavljamo da programi s ID-jevima 1, 2, 3, 5, 6, 7 postoje
INSERT INTO grupe (naziv, program, trener) VALUES
('Jutarnji Total Body Alpha', 1, 'Marko Marković'),      -- Sifra 1
('Večernja Yoga Flow', 2, 'Ana Anić'),                 -- Sifra 2
('CrossFit Elita', 3, 'Ivan Ivić'),                    -- Sifra 3
('Pilates Core', 2, 'Jelena Jelić'),                   -- Sifra 4
('Snaga Udar Popodne', 5, 'Petar Perić'),              -- Sifra 5
('Funkcionalni Ratnici', 6, 'Martina Horvat'),         -- Sifra 6
('Blago Istezanje Zora', 7, 'Stjepan Kovač');          -- Sifra 7

-- Unos podataka u tablicu vjezbaci (puno vježbača)
-- Kategorije: 1 (Student), 2 (Standard), 3 (Senior)
INSERT INTO vjezbaci (ime, prezime, email, kategorija) VALUES
('Pero', 'Perić', 'pero.peric@email.com', 2),           -- Sifra 1
('Maja', 'Majić', 'maja.majic@email.com', 1),           -- Sifra 2
('Ivan', 'Horvat', 'ivan.horvat@email.com', 2),         -- Sifra 3
('Ana', 'Kovač', 'ana.kovac@email.com', 3),             -- Sifra 4
('Luka', 'Babić', 'luka.babic@email.com', 2),           -- Sifra 5
('Tea', 'Matić', 'tea.matic@email.com', 1),             -- Sifra 6 (neće biti član)
('Nikola', 'Novak', 'nikola.novak@email.com', 2),       -- Sifra 7
('Sara', 'Kralj', 'sara.kralj@email.com', 2),           -- Sifra 8 (neće biti član)
('Marko', 'Knez', 'marko.knez@email.com', 1),           -- Sifra 9
('Iva', 'Jurić', 'iva.juric@email.com', 3),             -- Sifra 10
('Tomislav', 'Šimić', 'tomislav.simic@email.com', 2),   -- Sifra 11
('Petra', 'Vuković', 'petra.vukovic@email.com', 1),     -- Sifra 12 (neće biti član)
('Filip', 'Radić', 'filip.radic@email.com', 2),         -- Sifra 13
('Lucija', 'Zorić', 'lucija.zoric@email.com', 2),       -- Sifra 14
('Bruno', 'Grgić', 'bruno.grgic@email.com', 3),         -- Sifra 15 (neće biti član)
('Ema', 'Popović', 'ema.popovic@email.com', 1),         -- Sifra 16
('Domagoj', 'Klarić', 'domagoj.klaric@email.com', 2),   -- Sifra 17
('Elena', 'Tomić', 'elena.tomic@email.com', 1),         -- Sifra 18 (neće biti član)
('Josip', 'Pavlović', 'josip.pavlovic@email.com', 3),   -- Sifra 19
('Nika', 'Blažević', 'nika.blazevic@email.com', 2),     -- Sifra 20
('David', 'Rukavina', 'david.rukavina@email.com', 1),   -- Sifra 21
('Lorena', 'Kovačić', 'lorena.kovacic@email.com', 2),   -- Sifra 22 (neće biti član)
('Mihael', 'Lončar', 'mihael.loncar@email.com', 3),     -- Sifra 23
('Klara', 'Božić', 'klara.bozic@email.com', 1),         -- Sifra 24
('Patrik', 'Marić', 'patrik.maric@email.com', 2),       -- Sifra 25 (neće biti član)
('Gabrijela', 'Jukić', 'gabrijela.jukic@email.com', 2), -- Sifra 26
('Antonio', 'Brkić', 'antonio.brkic@email.com', 1),    -- Sifra 27
('Monika', 'Franić', 'monika.franic@email.com', 3),     -- Sifra 28 (neće biti član)
('Renato', 'Galić', 'renato.galic@email.com', 2),       -- Sifra 29
('Valentina', 'Cindrić', 'valentina.cindric@email.com', 1); -- Sifra 30

-- Unos podataka u tablicu clanovi
-- Povezujemo vježbače s grupama
-- Grupe imaju Sifra od 1 do 7
-- Vježbači imaju Sifra od 1 do 30
INSERT INTO clanovi (grupa, vjezbac) VALUES
(1, 1),  -- Pero Perić u Jutarnji Total Body Alpha
(2, 2),  -- Maja Majić u Večernja Yoga Flow
(3, 3),  -- Ivan Horvat u CrossFit Elita
(1, 4),  -- Ana Kovač u Jutarnji Total Body Alpha
(4, 5),  -- Luka Babić u Pilates Core
(5, 7),  -- Nikola Novak u Snaga Udar Popodne
(2, 9),  -- Marko Knez u Večernja Yoga Flow
(6, 10), -- Iva Jurić u Funkcionalni Ratnici
(3, 11), -- Tomislav Šimić u CrossFit Elita
(7, 13), -- Filip Radić u Blago Istezanje Zora
(4, 14), -- Lucija Zorić u Pilates Core
(1, 16), -- Ema Popović u Jutarnji Total Body Alpha
(5, 17), -- Domagoj Klarić u Snaga Udar Popodne
(6, 19), -- Josip Pavlović u Funkcionalni Ratnici
(7, 20), -- Nika Blažević u Blago Istezanje Zora
(2, 21), -- David Rukavina u Večernja Yoga Flow
(3, 23), -- Mihael Lončar u CrossFit Elita
(4, 24), -- Klara Božić u Pilates Core
(1, 26), -- Gabrijela Jukić u Jutarnji Total Body Alpha
(5, 27), -- Antonio Brkić u Snaga Udar Popodne
(6, 29), -- Renato Galić u Funkcionalni Ratnici
(7, 30); -- Valentina Cindrić u Blago Istezanje Zora

-- Vježbači koji NISU članovi NIJEDNE grupe (po njihovim Sifra nakon unosa):
-- 6 (Tea Matić)
-- 8 (Sara Kralj)
-- 12 (Petra Vuković)
-- 15 (Bruno Grgić)
-- 18 (Elena Tomić)
-- 22 (Lorena Kovačić)
-- 25 (Patrik Marić)
-- 28 (Monika Franić)


 --ispisati prihod po trenerima

select b.trener, count(c.vjezbac) as broj_clanova, count(c.vjezbac) * a.cijena as prihod
from programi a left join grupe b 
on a.sifra = b.program
left join clanovi c 
on b.sifra = c.grupa
group by b.trener, a.cijena;

--izvuci vjezbace koji nisu clanovi ni jedne grupe

