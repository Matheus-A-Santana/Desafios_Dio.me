namespace Desafio_Sistema_de_Hospedagem_Hotel.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private string _sobrenome;

        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O Nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome
        {
            get => _sobrenome.ToUpper();

            set{ _sobrenome = value; }
        }

    }
}