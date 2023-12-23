using Desafio_Sistema_de_Hospedagem_Hotel.Models;


// Cadastra uma lista de Hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "matheus" , sobrenome: "augusto");
Pessoa p2 = new Pessoa(nome: "ieda" , sobrenome: "duclos");

hospedes.Add(p1);
hospedes.Add(p2);

// Cadastra a suite
Suite suite = new Suite(nome: "Morfeu", capacidade: 3, valorDiaria: 35.00m);

// cria reserva para hospedes na suite
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastraSuite(suite);
reserva.CadastrarHospede(hospedes);

//exibe a quantidade de hospedes e o valor da diaria
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeDeHospede()}");
Console.WriteLine($"Hóspedes: {reserva.CalcularValorDiaria()}");