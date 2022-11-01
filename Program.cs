using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone tijolao = new Nokia(numero: "91981111111", modelo: "Lumia 520", imei: "1233456789123456", memoria: 7264);
tijolao.Ligar();
tijolao.InstalarAplicativo("Jogo da cobrinha");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "91991111111", modelo: "iPhone 4S", imei: "1233456789123457", memoria: 29650);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");