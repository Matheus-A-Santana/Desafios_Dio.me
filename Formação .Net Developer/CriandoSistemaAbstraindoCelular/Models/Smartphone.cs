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
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

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