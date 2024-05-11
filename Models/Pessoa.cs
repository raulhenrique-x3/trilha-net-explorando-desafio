namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

    public Pessoa() { }
    public List<Pessoa> hospedes = new List<Pessoa>();

    public void cadastrarPessoa()
    {
        while (true)
        {
            Console.WriteLine("Digite o nome do hóspede ou digite 'sair' para sair:");
            string nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome não pode ser vazio");
                continue;
            }

            if (nome.Length < 2)
            {
                Console.WriteLine("Nome deve conter no mínimo 3 caracteres");
                continue;
            }

            if (nome.Equals("sair", StringComparison.CurrentCultureIgnoreCase))
            {
                break;
            }

            Pessoa nomeHospede = new Pessoa { Nome = nome };
            hospedes.Add(nomeHospede);
        }

    }

    public List<Pessoa> retornarListaPessoa()
    {
        return hospedes;
    }

    public void removerPessoa()
    {
        Console.WriteLine("Digite o nome do hóspede que deseja remover:");
        string nome = Console.ReadLine();
        Pessoa nomeHospede = new Pessoa { Nome = nome };

        if (hospedes.Contains(nomeHospede))
        {
            hospedes.Remove(nomeHospede);
            Console.WriteLine("Hóspede removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Hóspede não encontrado");
        }
    }

    public void listarHospedes()
    {
        foreach (Pessoa hospede in hospedes)
        {
            Console.WriteLine(hospede.Nome);
        }
    }
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

}