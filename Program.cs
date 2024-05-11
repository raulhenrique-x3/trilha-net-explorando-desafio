using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
Pessoa pessoa = new Pessoa();
Suite suites = new Suite();
Reserva reserva = new Reserva();

Console.WriteLine("Bem vindo ao sistema de hospedagem!");
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a opção desejada:");
    Console.WriteLine("1 - Cadastrar hóspedes");
    Console.WriteLine("2 - Cadastrar suíte");
    Console.WriteLine("3 - Reservar suíte");
    Console.WriteLine("4 - Exibir hospedes cadastrados");
    Console.WriteLine("5 - Exibir suites cadastradas");
    Console.WriteLine("6 - Sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            pessoa.cadastrarPessoa();
            Console.WriteLine(pessoa.Nome);
            break;
        case "2":
            suites.criarSuite();
            break;
        case "3":
            foreach (Suite suite in suites.listaSuites())
            {
                if (suite.Capacidade > 0 && pessoa.retornarListaPessoa().Count > 0)
                {
                    reserva.CadastrarHospedes(pessoa.retornarListaPessoa(), suites.listaSuites());
                    int diasReservados = reserva.ReservarDias();
                    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
                    Console.WriteLine($"Dias reservados: {diasReservados}");
                    Console.WriteLine($"Valor Suite: R$ {suite.ValorDiaria}");
                    Console.WriteLine($"Valor diária: R$ {reserva.CalcularValorDiaria(diasReservados, suite)}");
                    Console.WriteLine($"Total: R$ {reserva.CalcularValorDiaria(diasReservados, suite) * diasReservados}");
                }
                else
                {
                    Console.WriteLine("Erro: Você deve cadastrar uma suíte e hóspedes antes de reservar.");
                }
                break;
            }
            break;
        case "4":
            pessoa.listarHospedes();
            break;
        case "5":
            suites.listarSuites();
            break;
        case "6":
            exibirMenu = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}
