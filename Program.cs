using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero :"123456", modelo :"1", imei :"11111111", memoria: 54);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp"); 

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia(numero :"123456", modelo :"1", imei :"11111111", memoria: 54);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp"); 