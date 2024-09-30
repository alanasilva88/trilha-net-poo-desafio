using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando instância de Iphone e testando seus métodos
            Smartphone iphone = new Iphone("987654321", "iPhone 14", "111111111111111", 128);
            Console.WriteLine("Testando Iphone:");
            iphone.Ligar();
            iphone.ReceberLigacao(); 
            iphone.InstalarAplicativo("Instagram");
            Console.WriteLine(); 

            // Criando instância de Nokia e testando seus métodos
            Smartphone nokia = new Nokia("123456789", "Nokia 3310", "222222222222222", 64);
            Console.WriteLine("Testando Nokia:");
            nokia.Ligar(); 
            nokia.ReceberLigacao(); 
            nokia.InstalarAplicativo("WhatsApp"); 
        }
    }
}
