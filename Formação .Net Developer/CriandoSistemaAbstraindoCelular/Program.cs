using CriandoSistemaAbstraindoCelular.Models;

// criando celular nokia
Smartphone nokia = new Nokia(numero: "981165165",modelo: "tijolo",Imei: "5asdf6as5dfasdf4a6df4as654",memoria: 256);

//criando celular iphone
Smartphone XR = new Iphone(numero: "651165616",modelo: "XR",Imei: "adfa5a4df6asd51fa6sdf4a5sd6f",memoria: 128);


//chamando ligar e receber ligação de nokia
Console.WriteLine("Smartphone Nokia: ");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");
//chamando ligar e receber ligação de Iphone
Console.WriteLine("Smartphone Iphone: ");
XR.Ligar();
XR.ReceberLigacao();
XR.InstalarAplicativo("Telegram");

