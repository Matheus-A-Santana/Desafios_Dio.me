namespace CriandoSistemaAbstraindoCelular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string Imei, int memoria) : base(numero, modelo, Imei, memoria)
        {
        }


        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o app {nome}, em seu Iphone");
        }

    }
}