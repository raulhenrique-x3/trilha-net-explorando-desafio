namespace DesafioProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite() { }

        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }

        public List<Suite> suites = new List<Suite>();

        public void criarSuite()
        {
            Console.WriteLine("Digite o tipo da suíte:");
            string tipoSuite = Console.ReadLine();
            Console.WriteLine("Digite a capacidade da suíte:");
            int capacidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da diária:");
            decimal valorDiaria = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Suíte cadastrada com sucesso!");
            Suite suite = new Suite { TipoSuite = tipoSuite, Capacidade = capacidade, ValorDiaria = valorDiaria };
            suites.Add(suite);
        }

        public List<Suite> listaSuites()
        {
            return suites;
        }

        public void listarSuites()
        {
            foreach (var suite in suites)
            {
                Console.WriteLine($"Tipo: {suite.TipoSuite}");
                Console.WriteLine($"Capacidade: {suite.Capacidade}");
                Console.WriteLine($"Valor diária: {suite.ValorDiaria}");
            }
        }
    }
}