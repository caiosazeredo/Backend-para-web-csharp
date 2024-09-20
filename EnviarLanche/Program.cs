
using System.Net.Http.Json;


// Define o modelo do pedido
public class Pedido
{
    public int Id { get; set; }
    public string Cliente { get; set; }
    public string Item { get; set; }
    public int Quantidade { get; set; }
    public decimal ValorTotal { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        // URL da API (ajuste conforme o endereço da API)
        string apiUrl = "https://localhost:7045/api/pedido";
        

        // Solicita informações do pedido ao usuário
        Console.Write("Digite o nome do cliente: ");
        string cliente = Console.ReadLine();

        Console.Write("Digite o item do pedido: ");
        string item = Console.ReadLine();

        Console.Write("Digite a quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor total: ");
        decimal valorTotal = decimal.Parse(Console.ReadLine());

        // Cria um novo pedido
        Pedido novoPedido = new Pedido
        {
            Cliente = cliente,
            Item = item,
            Quantidade = quantidade,
            ValorTotal = valorTotal
        };

        // Envia o pedido para a API
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, novoPedido);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Pedido enviado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao enviar o pedido.");
            }
        }
    }
}
