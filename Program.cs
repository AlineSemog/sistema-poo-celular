using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "123789456", modelo: "15 Pro Max", imei: "654789", memoria: 88);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "G11", imei: "987654", memoria: 44);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");


