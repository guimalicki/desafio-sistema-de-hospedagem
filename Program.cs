
using sistema_de_hospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>();

//Cadastro das pessoas
Pessoa p1 = new Pessoa("Guilherme", "Malicki");
Pessoa p2 = new Pessoa("Angela", "Malicki");

//Adição das pessoas na lista de hóspedes
hospedes.Add(p1);
hospedes.Add(p2);

//Criação da suite
Suite suite = new Suite("Premium", 2, 30M);

//Criação da reserva
Reserva reserva = new Reserva(10);
//Cadastro da suite
reserva.CadastrarSuite(suite);

//Cadastro dos hóspedes
reserva.CadastrarHospedes(hospedes);

//Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");







