use edunovawp8;
select * from smjerovi;


-- 1 -> ovo je šifra koju će dodijeliti baza
insert into smjerovi (naziv, cijena, datumpokretanja, aktivan)
values ('Web programiranje', 1200.54, '2025-05-16 17:00:01', 1);

insert into smjerovi (naziv) values
-- 2
('Serviser'), 
-- 3
('Web dizajn'), 
-- 4
('Marketing');

select * from grupe;

insert into grupe (naziv, smjer) 
values 
-- 1
('WP8', 1), -- 'WP8', 1 (broj 1 je vanjski kljuc koji odgovara sifri smjera)
-- 2
('WP7', 1), 
-- 3
('S1', 2);

