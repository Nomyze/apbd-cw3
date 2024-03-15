// See https://aka.ms/new-console-template for more information
using cw3.Kontenery;

Console.WriteLine("Hello, World!");

PKontener pkd = new PKontener(10, 10, 10.0, 10.0, 'd');
pkd.load(4.9);
pkd.empty();
pkd.load(5.1);
PKontener pks = new PKontener(5, 5, 5.0, 5.0, 's');
pks.load(4.8);
