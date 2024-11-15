

using DesafioPOO.Models;


Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "123456",modelo: "modelo 1", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone= new Iphone(numero: "78910",modelo: "modelo 2", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

