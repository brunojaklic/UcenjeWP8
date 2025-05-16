use edunovawp8;

select * from smjerovi where sifra = 2;

update smjerovi
set aktivan = 1
where sifra = 2;

update smjerovi set 
cijena = 1000,
datumpokretanja = '2024-02-29'
where sifra = 3;

update smjerovi set cijena = 1000 where cijena is null;

-- dižemo cijenu svih smjerova za 12%

update smjerovi set cijena = cijena * 1.12;

-- smanjiti cijene za 10 %

update smjerovi set cijena = cijena * 0.9;

-- popust na sve smjerove 10 %

update smjerovi set cijena = cijena * 0.9;

-- delete naredba brise podatke iz tablice

delete smjerovi where sifra = 1;
delete grupe where smjer = 1;
delete clanovi where grupa in (select sifra from grupe where smjer = 1);

-- postoji opcija cascade ALI JU NE BIH PREPORUČIO