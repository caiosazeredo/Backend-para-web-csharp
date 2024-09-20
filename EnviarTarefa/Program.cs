
using System.Net.Http.Json;


// Define o modelo da tarefa que vamos enviar para a API
public class Tarefa
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public bool Concluida { get; set; }
}

class Program
{
    static async Task Main(string[] args)
    {
        // URL da API (ajuste o IP e a porta conforme o necessário)
        string apiUrl = "https://localhost:7122/api/tarefas";

        // Solicitar entrada do usuário para criar uma nova tarefa
        Console.WriteLine("Adicionar uma nova tarefa:");

        // Obtendo o título da tarefa
        Console.Write("Digite o título da tarefa: ");
        string titulo = Console.ReadLine();

        // Obtendo o status de conclusão da tarefa (Sim ou Não)
        bool concluida = false;
        Console.Write("A tarefa está concluída? (Sim/Não): ");
        string resposta = Console.ReadLine().ToLower();

        if (resposta == "sim")
        {
            concluida = true;
        }

        // Criando uma nova tarefa para enviar para a API
        Tarefa novaTarefa = new Tarefa
        {
            Titulo = titulo,
            Concluida = concluida
        };

        // Enviando a tarefa para a API
        using (HttpClient client = new HttpClient())
        {
            // Enviando a requisição POST para a API
            HttpResponseMessage response = await client.PostAsJsonAsync(apiUrl, novaTarefa);

            // Verificando se a requisição foi bem-sucedida
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Tarefa adicionada com sucesso!");
                var tarefaCriada = await response.Content.ReadFromJsonAsync<Tarefa>();
                Console.WriteLine($"ID: {tarefaCriada.Id}, Título: {tarefaCriada.Titulo}, Concluída: {tarefaCriada.Concluida}");
            }
            else
            {
                Console.WriteLine("Erro ao adicionar tarefa.");
                Console.WriteLine($"Status Code: {response.StatusCode}");
            }
        }
    }
}
