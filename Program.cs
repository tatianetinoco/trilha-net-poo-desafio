﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iPhone = new Iphone(numero: "7891011", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iPhone.Ligar();
iPhone.InstalarAplicativo("Telegram");
