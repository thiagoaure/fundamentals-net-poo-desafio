using DesafioPOO.Models;

Smartphone nokia = new Nokia("3599999999", "Modelo N3", "111000", "16");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("DIO");

Smartphone iphone = new Iphone("11888888", "Modelo 14", "000111", "128");
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
