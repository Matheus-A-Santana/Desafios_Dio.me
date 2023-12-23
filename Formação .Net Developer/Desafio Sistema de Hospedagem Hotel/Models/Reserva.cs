using System.Xml.Schema;

namespace Desafio_Sistema_de_Hospedagem_Hotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set;}
        public Suite Suite{ get; set; }
        private int _diasReservados;
        public Reserva(){ }
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public decimal CalcularValorDiaria()
        {
            if(_diasReservados >= 10)
            {
                decimal total = Suite.ValorDiaria * _diasReservados;
                return total - (total * 0.1m);
            }
            return Suite.ValorDiaria * _diasReservados;
        }
        public void CadastraSuite(Suite suite)
        {
            Suite = suite;
        }
        public void CadastrarHospede(List<Pessoa> hospedes)
        {
            if(hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Não é possivel cadastrar quantidade hospedes maior que a capacidade da suite");
            }
        }
        public int ObterQuantidadeDeHospede()
        {
            return Hospedes.Count;
        }
        public int DiasReservados
        {
            get => _diasReservados;

            set
            {
                if( value < 1 )
                {
                    throw new ArgumentException("O valor não pode ser menor que 1");
                }
                _diasReservados = value;
            }
        }
    }
}