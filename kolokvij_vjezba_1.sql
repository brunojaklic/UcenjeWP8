use master;
go
drop database if exists kolokvij_vjezba_1;
go
create database kolokvij_vjezba_1;
go
use kolokvij_vjezba_1;

create table svekar(
	sifra int not null primary key identity(1,1),
	bojaociju varchar(40) not null,
	prstena int,
	dukserica varchar(41),
	lipa decimal(13,8),
	eura decimal(12,7),
	majica varchar(35)
);

create table sestra(
	sifra int not null primary key identity(1,1),
	introvertno bit,
	haljina varchar(31) not null,
	maraka decimal(16,6),
	hlace varchar(46) not null,
	narukvica int not null
);

create table zena(
	sifra int not null primary key identity(1,1),
	treciputa datetime,
	hlace varchar(46),
	kratkamajica varchar(31) not null,
	jmbag char(11) not null,
	bojaociju varchar(39) not null,
	haljina varchar(44),
	sestra int not null references sestra(sifra)
);

create table sestra_svekar(
	sifra int not null primary key identity(1,1),
	sestra int not null references sestra(sifra),
	svekar int not null references svekar(sifra)
);

create table muskarac(
	sifra int not null primary key identity(1,1),
	bojaociju varchar(50) not null,
	hlace varchar(30),
	modelnaocala varchar(43),
	maraka decimal(14,5) not null,
	zena int not null references zena(sifra)
);

create table mladic(
	sifra int not null primary key identity(1,1),
	suknja varchar(50) not null,
	kuna decimal(16,8) not null,
	drugiputa datetime,
	asocijalno bit,
	ekstrovertno bit not null,
	dukserica varchar(48) not null,
	muskarac int references muskarac(sifra)
);

create table punac(
	sifra int not null primary key identity(1,1),
	ogrlica int,
	gustoca decimal(14,9),
	hlace varchar(41) not null
);

create table cura(
	sifra int not null primary key identity(1,1),
	novcica decimal(16,5) not null,
	gustoca decimal(18,6) not null,
	lipa decimal (13,10),
	ogrlica int not null,
	bojakose varchar(38),
	suknja varchar(36),
	punac int references punac(sifra)
);

INSERT INTO svekar (bojaociju, prstena, dukserica, lipa, eura, majica) VALUES
('plava', 3, 'hoodie', 123.45678901, 789.0123456, 'T-shirt'),
('smeđa', 7, 'pulover', 987.65432109, 234.5678901, 'polo majica'),
('zelena', 1, 'sportska majica', 456.78901234, 567.8901234, 'košulja'),
('crna', 5, 'džemper', 11.22334455, 66.7788990, 'duga majica'),
('siva', 2, 'kardigan', 333.44455566, 111.2223334, 'majica bez rukava'),
('žuta', 8, 'jakna', 777.88899900, 999.0001112, 'majica s kapuljačom'),
('ljubičasta', 4, 'trenerka', 55.66778899, 33.4455667, 'potkošulja'),
('smeđa', 6, 'prsluk', 222.33344455, 888.9990001, 'sportska majica'),
('plava', 9, 'majica kratkih rukava', 666.77788899, 444.5556667, 'majica s natpisom'),
('zelena', 10, 'top', 10.98765432, 20.1234567, 'majica na bretele');

INSERT INTO sestra (introvertno, haljina, maraka, hlace, narukvica) VALUES
(0, 'ljetna haljina', 12345.678901, 'traperice', 2),
(1, 'večernja haljina', 9876.543210, 'hlače na crtu', 1),
(0, 'midi haljina', 54321.098765, 'kratke hlače', 3),
(1, 'maksi haljina', 1111.222233, 'tajice', 4),
(0, 'mini haljina', 99999.888877, 'hlače na preklop', 5),
(1, 'koktel haljina', 123.456789, 'chino hlače', 6),
(0, 'pencil haljina', 7654.321098, 'lanene hlače', 7),
(1, 'tunika haljina', 87654.321098, 'bermude', 8),
(0, 'slip haljina', 2345.678901, 'cargo hlače', 9),
(1, 'A-kroj haljina', 345.678901, 'elastične hlače', 10);

INSERT INTO zena (treciputa, hlace, kratkamajica, jmbag, bojaociju, haljina, sestra) VALUES
('2023-01-15 10:30:00', 'plave traperice', 'bijela kratka majica', '12345678901', 'plava', 'cvjetna haljina', 1),
('2024-02-20 14:00:00', 'crne hlače', 'crna kratka majica', '09876543210', 'smeđa', 'crvena haljina', 2),
('2023-03-01 09:15:00', 'zelene hlače', 'žuta kratka majica', '11223344556', 'zelena', 'crna haljina', 3),
('2024-04-10 11:45:00', 'bež hlače', 'siva kratka majica', '66554433221', 'siva', 'plava haljina', 4),
('2023-05-22 16:00:00', 'bijele hlače', 'roza kratka majica', '10293847560', 'plava', 'bijela haljina', 5),
('2024-06-05 08:00:00', 'sive hlače', 'zelena kratka majica', '01928374659', 'smeđa', 'žuta haljina', 6),
('2023-07-18 13:20:00', 'plave hlače', 'plava kratka majica', '12312312312', 'zelena', 'zelena haljina', 7),
('2024-08-01 17:10:00', 'crne hlače', 'bijela kratka majica', '32132132132', 'crna', 'ljubičasta haljina', 8),
('2023-09-09 10:00:00', 'bijele hlače', 'crna kratka majica', '45645645645', 'siva', 'smeđa haljina', 9),
('2024-10-14 12:50:00', 'sive hlače', 'žuta kratka majica', '78978978978', 'žuta', 'roza haljina', 10);

INSERT INTO svekar (bojaociju, prstena, dukserica, lipa, eura, majica) VALUES
('plava', 3, 'hoodie', 123.45678901, 789.0123456, 'T-shirt'),
('smeđa', 7, 'pulover', 987.65432109, 234.5678901, 'polo majica'),
('zelena', 1, 'sportska majica', 456.78901234, 567.8901234, 'košulja'),
('crna', 5, 'džemper', 11.22334455, 66.7788990, 'duga majica'),
('siva', 2, 'kardigan', 333.44455566, 111.2223334, 'majica bez rukava'),
('žuta', 8, 'jakna', 777.88899900, 999.0001112, 'majica s kapuljačom'),
('ljubičasta', 4, 'trenerka', 55.66778899, 33.4455667, 'potkošulja'),
('smeđa', 6, 'prsluk', 222.33344455, 888.9990001, 'sportska majica'),
('plava', 9, 'majica kratkih rukava', 666.77788899, 444.5556667, 'majica s natpisom'),
('zelena', 10, 'top', 10.98765432, 20.1234567, 'majica na bretele');

INSERT INTO sestra (introvertno, haljina, maraka, hlace, narukvica) VALUES
(0, 'ljetna haljina', 12345.678901, 'traperice', 2),
(1, 'večernja haljina', 9876.543210, 'hlače na crtu', 1),
(0, 'midi haljina', 54321.098765, 'kratke hlače', 3),
(1, 'maksi haljina', 1111.222233, 'tajice', 4),
(0, 'mini haljina', 99999.888877, 'hlače na preklop', 5),
(1, 'koktel haljina', 123.456789, 'chino hlače', 6),
(0, 'pencil haljina', 7654.321098, 'lanene hlače', 7),
(1, 'tunika haljina', 87654.321098, 'bermude', 8),
(0, 'slip haljina', 2345.678901, 'cargo hlače', 9),
(1, 'A-kroj haljina', 345.678901, 'elastične hlače', 10);

INSERT INTO zena (treciputa, hlace, kratkamajica, jmbag, bojaociju, haljina, sestra) VALUES
('2023-01-15 10:30:00', 'plave traperice', 'bijela kratka majica', '12345678901', 'plava', 'cvjetna haljina', 1),
('2024-02-20 14:00:00', 'crne hlače', 'crna kratka majica', '09876543210', 'smeđa', 'crvena haljina', 2),
('2023-03-01 09:15:00', 'zelene hlače', 'žuta kratka majica', '11223344556', 'zelena', 'crna haljina', 3),
('2024-04-10 11:45:00', 'bež hlače', 'siva kratka majica', '66554433221', 'siva', 'plava haljina', 4),
('2023-05-22 16:00:00', 'bijele hlače', 'roza kratka majica', '10293847560', 'plava', 'bijela haljina', 5),
('2024-06-05 08:00:00', 'sive hlače', 'zelena kratka majica', '01928374659', 'smeđa', 'žuta haljina', 6),
('2023-07-18 13:20:00', 'plave hlače', 'plava kratka majica', '12312312312', 'zelena', 'zelena haljina', 7),
('2024-08-01 17:10:00', 'crne hlače', 'bijela kratka majica', '32132132132', 'crna', 'ljubičasta haljina', 8),
('2023-09-09 10:00:00', 'bijele hlače', 'crna kratka majica', '45645645645', 'siva', 'smeđa haljina', 9),
('2024-10-14 12:50:00', 'sive hlače', 'žuta kratka majica', '78978978978', 'žuta', 'roza haljina', 10);

INSERT INTO sestra_svekar (sestra, svekar) VALUES
(1, 1),
(1, 2),
(2, 1),
(2, 3),
(3, 4),
(4, 5),
(5, 6),
(6, 7),
(7, 8),
(8, 9),
(9, 10),
(10, 1),
(1, 3),
(2, 4),
(3, 5),
(4, 6),
(5, 7),
(6, 8),
(7, 9),
(8, 10);

INSERT INTO muskarac (bojaociju, hlace, modelnaocala, maraka, zena) VALUES
('plava', 'traperice', 'aviator', 15000.50, 1),
('smeđa', 'chino hlače', 'wayfarer', 20000.75, 2),
('zelena', 'cargo hlače', 'clubmaster', 12345.67, 3),
('crna', 'sportske hlače', 'okrugle', 9876.54, 4),
('siva', 'lanene hlače', 'cat eye', 30000.00, 5),
('plava', 'hlače na crtu', 'nerd', 18000.25, 6),
('smeđa', 'kratke hlače', 'pilot', 25000.99, 7),
('zelena', 'traperice', 'retro', 11000.11, 8),
('crna', 'hlače za odijelo', 'kvadratne', 50000.00, 9),
('siva', 'trenirka', 'ovalne', 7500.80, 10),
('plava', 'jogger hlače', 'sport', 10000.00, 1),
('smeđa', 'uske traperice', 'moderne', 13000.00, 2);

INSERT INTO mladic (suknja, kuna, drugiputa, asocijalno, ekstrovertno, dukserica, muskarac) VALUES
('sportska suknja', 100.50, '2025-01-01 10:00:00', 0, 1, 'hoodie', 1),
('traper suknja', 250.75, '2025-02-05 11:30:00', 1, 0, 'zip-up', 2),
('maxi suknja', 50.25, '2025-03-10 14:00:00', 0, 1, 'crewneck', 3),
('mini suknja', 300.00, '2025-04-15 09:00:00', 1, 0, 'pulover', 4),
('midi suknja', 120.10, '2025-05-20 16:00:00', 0, 1, 'trenerka', 5),
('pencil suknja', 80.80, '2025-06-25 13:00:00', 1, 0, 'dukserica s kapuljačom', 6),
('plisirana suknja', 180.30, '2025-07-30 10:00:00', 0, 1, 'baseball dukserica', 7),
('kožna suknja', 400.00, '2025-08-01 11:00:00', 1, 0, 'oversize dukserica', 8),
('suknja A-kroja', 75.60, '2025-09-05 15:00:00', 0, 1, 'vunena dukserica', 9),
('asimetrična suknja', 220.90, '2025-10-10 12:00:00', 1, 0, 'pamučna dukserica', 10),
('pletena suknja', 90.00, '2025-11-15 08:30:00', 0, 1, 'fleece dukserica', 1),
('traper suknja', 150.00, '2025-12-20 17:00:00', 1, 0, 'sportski duks', 2);

INSERT INTO punac (ogrlica, gustoca, hlace) VALUES
(1, 1.234567890, 'traperice'),
(2, 0.987654321, 'svečane hlače'),
(3, 2.109876543, 'lanene hlače'),
(4, 0.543210987, 'sportske hlače'),
(5, 1.765432109, 'chino hlače'),
(6, 0.333444555, 'kratke hlače'),
(7, 1.010203040, 'hlače na crtu'),
(8, 0.777888999, 'teretne hlače'),
(9, 1.500000000, 'trenerka'),
(10, 0.123456789, 'samterice');

INSERT INTO cura (novcica, gustoca, lipa, ogrlica, bojakose, suknja, punac) VALUES
(100.00, 1.234567, 0.1234567890, 1, 'smeđa', 'traper suknja', 1),
(250.50, 0.987654, 0.9876543210, 2, 'plava', 'maxi suknja', 2),
(75.20, 2.109876, 0.1122334455, 3, 'crna', 'midi suknja', 3),
(500.00, 0.543210, 0.9988776655, 4, 'riđa', 'mini suknja', 4),
(120.75, 1.765432, 0.0102030405, 5, 'plava', 'pletena suknja', 5),
(30.15, 0.333444, 0.5566778899, 6, 'smeđa', 'kožna suknja', 6),
(180.90, 1.010203, 0.0011223344, 7, 'crvena', 'sportska suknja', 7),
(90.00, 0.777888, 0.7766554433, 8, 'zelena', 'cvjetna suknja', 8),
(350.25, 1.500000, 0.1212121212, 9, 'ljubičasta', 'šarena suknja', 9),
(15.80, 0.123456, 0.9898989898, 10, 'crna', 'lanena suknja', 10),
(200.00, 1.000000, 0.5000000000, 1, 'plava', 'traper suknja', 1);

update cura set gustoca = 15.77;

delete from mladic where kuna > 15.78;
select * from mladic;

select kratkamajica from zena
where hlace like '%ana%';

select a.dukserica, f.asocijalno, e.hlace
from svekar a join sestra_svekar b
on a.sifra = b.svekar
join sestra c
on b.sestra = c.sifra
join zena d
on c.sifra = d.sestra
join muskarac e
on d.sifra = e.zena
join mladic f
on e.sifra = f.muskarac
where d.hlace like '%a' and c.haljina like '%be%'
order by e.hlace desc;

select a.haljina, a.maraka
from sestra a left join sestra_svekar b
on a.sifra = b.sestra
where b.sestra is null;

