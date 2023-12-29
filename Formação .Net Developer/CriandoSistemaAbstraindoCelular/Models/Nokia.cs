namespace CriandoSistemaAbstraindoCelular.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string Imei, int memoria) : base(numero, modelo, Imei, memoria)
        {

        }


        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o app {nome}, em seu Nokia");
        }

    }
}