namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Reserva() { }

        public int ReservarDias()
        {
            Console.WriteLine("Digite a quantidade de dias que deseja reservar:");

            int DiasReservados = Convert.ToInt32(Console.ReadLine());

            return DiasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes, List<Suite> suite)
        {
            if (hospedes.Count == 0)
            {
                throw new Exception("Nenhum hóspede cadastrado");
            }

            foreach (Suite suites in suite)
            {
                Console.WriteLine($"Capacidade da suíte: {suites.Capacidade}");
                Console.WriteLine($"Quantidade de hóspedes: {hospedes.Count}");
                if (suites.Capacidade > hospedes.Count)
                {
                    Hospedes = hospedes;
                    Console.WriteLine("Hóspedes cadastrados com sucesso!");
                }
                else
                {
                    throw new Exception("Capacidade da suíte menor que o número de hóspedes");
                }
            }
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria(int diasReservados, Suite suite)
        {
            decimal valor = diasReservados * suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (diasReservados >= 10)
            {
                valor = valor * 10 / 100;
                Console.WriteLine("Desconto de 10% aplicado!");
                return valor;
            }

            return valor;
        }
    }
}