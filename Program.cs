// See https://aka.ms/new-console-template for more information
using cw3.Kontenery;
using cw3.types;

PKontener pkd = new PKontener(10, 10, 10.0, 10.0, 'd');
pkd.load(4.9);
pkd.empty();
pkd.load(5.1);
PKontener pks = new PKontener(5, 5, 5.0, 5.0, 's');
pks.load(4.8);

GKontener gk = new GKontener(5, 5, 2.0, 5.0);
gk.load(4.8);
gk.empty();

Produkt banan = new Produkt("banan", 13.3);
CKontener ck = new CKontener(5, 5, 3.4, 7.124, banan, 13.5);

Kontenerowiec kon = new Kontenerowiec(2.0, 1000.0, 3);
kon.load(ck);
List<Kontener> lk = new List<Kontener>();
lk.Add(pkd);
lk.Add(pks);
lk.Add(gk);
kon.load(lk);
kon.get_info();

kon.remove(pkd);
kon.get_info();
kon.change(0, pkd);
kon.get_info();
Kontenerowiec kon1 = new Kontenerowiec(2.0, 1000.0, 3);
kon.exchange(kon1, 0);
kon.get_info();
kon1.get_info();
