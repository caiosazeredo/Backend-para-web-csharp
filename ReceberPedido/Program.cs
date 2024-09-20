
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

        // Requisição GET para receber todos os pedidos
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Agora recebemos uma lista de pedidos
                List<Pedido> pedidos = await client.GetFromJsonAsync<List<Pedido>>(apiUrl);

                if (pedidos != null && pedidos.Count > 0)
                {
                    Console.WriteLine("Pedidos atuais:");

                    // Itera por todos os pedidos e os exibe
                    foreach (var pedido in pedidos)
                    {
                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"ID: {pedido.Id}");
                        Console.WriteLine($"Cliente: {pedido.Cliente}");
                        Console.WriteLine($"Item: {pedido.Item}");
                        Console.WriteLine($"Quantidade: {pedido.Quantidade}");
                        Console.WriteLine($"Valor Total: {pedido.ValorTotal:C}");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum pedido foi encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao acessar a API: {ex.Message}");
            }
        }
    }
}
