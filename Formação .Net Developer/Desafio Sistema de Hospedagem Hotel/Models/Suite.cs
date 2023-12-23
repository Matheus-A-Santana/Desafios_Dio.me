using System.Runtime.Serialization;
using System.Security;

namespace Desafio_Sistema_de_Hospedagem_Hotel.Models
{
    public class Suite
    {
        public Suite(string nome, int capacidade, decimal valorDiaria)
        {
            Nome = nome;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        
        private string _nome;
        private int _capacidade;
        private decimal _valorDiaria;

        public string Nome
        {
            get => _nome;

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Não pode ser vazio");
                }
                _nome = value;
            }
        }

        public int Capacidade
        {
            get => _capacidade;

            set
            {
                if(value < 1)
                {
                    throw new ArgumentException("O valor não pode ser menor que 1");
                }
                _capacidade = value;
            }
        }

        public decimal ValorDiaria
        {
            get => _valorDiaria;

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("O valor não pode ser menor que 0");
                }
                _valorDiaria = value;
            }
        }
    }
}