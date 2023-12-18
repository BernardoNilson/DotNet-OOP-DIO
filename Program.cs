using DotNet_OOP_DIO.Models;

// Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iniciando o programa!");

Iphone iphone = new Iphone("999887766", "iPhone 11 Pro", "927387492347", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");

Nokia nokia = new Nokia("922334455", "Nokia X7 Ultra", "24526346435", 256);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("StreetFighter X6");

Console.WriteLine("Finalizando o programa!");