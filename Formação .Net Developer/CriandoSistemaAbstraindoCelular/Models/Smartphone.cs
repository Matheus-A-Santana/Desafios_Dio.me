namespace CriandoSistemaAbstraindoCelular.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string Imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = Imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando....");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo Ligação...");
        }

        public abstract void InstalarAplicativo(string nome);
    }
}