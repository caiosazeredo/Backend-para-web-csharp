
using System.Net.Http.Json;


namespace ProdutoConsoleApp
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            // URL da sua API (altere para o endereço onde sua API está sendo executada)
            string apiUrl = "https://localhost:7148/api/produto";

            // Cria um cliente HTTP
            HttpClient client = new HttpClient();

            // Solicita os dados do produto ao usuário
            Console.WriteLine("Digite o nome do produto:");
            string nome = Console.ReadLine();

            // Validação para garantir que o valor seja maior que 10
            decimal valor;
            do
            {
                Console.WriteLine("Digite o valor do produto (deve ser maior que 10):");
                valor = decimal.Parse(Console.ReadLine());

                if (valor <= 10)
                {
                    Console.WriteLine("Erro: O valor do produto deve ser maior que 10. Tente novamente.");
                }
            } while (valor <= 10);  // Repete até que o valor seja válido

            Console.WriteLine("Digite a quantidade do produto:");
            int quantidade = int.Parse(Console.ReadLine());

            // Cria um novo objeto produto com os dados do usuário
            Produto novoProduto = new Produto
            {
                Nome = nome,
                Valor = valor,
                Quantidade = quantidade
            };

            // Envia uma requisição POST para a API com os dados do produto
            HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, novoProduto);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Produto enviado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Erro ao enviar produto: {response.StatusCode}");
            }
        }
    }
}
