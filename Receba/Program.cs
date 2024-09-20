using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

// Define o modelo da tarefa que vamos receber da API
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
        string apiUrl = "http://192.168.56.1:7122/api/tarefas";

        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Fazendo a requisição GET para buscar todas as tarefas
                List<Tarefa> tarefas = await client.GetFromJsonAsync<List<Tarefa>>(apiUrl);

                if (tarefas != null && tarefas.Count > 0)
                {
                    // Exibindo todas as tarefas retornadas pela API
                    Console.WriteLine("Tarefas:");
                    foreach (var tarefa in tarefas)
                    {
                        string status = tarefa.Concluida ? "Concluída" : "Pendente";
                        Console.WriteLine($"ID: {tarefa.Id}, Título: {tarefa.Titulo}, Status: {status}");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma tarefa encontrada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao acessar a API: {ex.Message}");
            }
        }
    }
}
