using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Exceptions;
using System.Threading;
using Google.Cloud.AIPlatform.V1;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;
using Newtonsoft.Json.Linq;

class Program
{
    // Coloque seu token do bot aqui
    private static readonly string BotToken = "SEU_TELEGRAM_BOT_TOKEN";
    private static TelegramBotClient botClient;

    static void Main(string[] args)
    {
        // Configurar a variável de ambiente para a autenticação do GCP
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "caminho/para/seu/arquivo-chave.json");

        // Inicializa o cliente do bot com o token
        botClient = new TelegramBotClient(BotToken);

        // Configurações para o recebimento de mensagens
        var receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = Array.Empty<UpdateType>() // Recebe todos os tipos de atualizações
        };

        // Inicia o recebimento de atualizações
        botClient.StartReceiving(HandleUpdateAsync, HandleErrorAsync, receiverOptions);

        Console.WriteLine("Bot iniciado. Pressione qualquer tecla para parar o bot...");
        Console.ReadKey();

        // Para o recebimento de mensagens
        botClient.CloseAsync().Wait();
    }

    // Método para processar as atualizações (mensagens)
    private static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        // Apenas processa mensagens de texto
        if (update.Type == UpdateType.Message && update.Message!.Text != null)
        {
            var message = update.Message;
            var userMessage = message.Text.ToLower();

            // Verifica condições usando if-else
            string botResponse;
            if (userMessage.Contains("oi") || userMessage.Contains("olá"))
            {
                botResponse = "Olá! Como posso ajudar você hoje?";
            }
            else if (userMessage.Contains("qual o seu nome?"))
            {
                botResponse = "Eu sou um bot Telegram, aqui para te ajudar!";
            }
            else if (userMessage.Contains("que horas são?"))
            {
                botResponse = $"Agora são {DateTime.Now.ToShortTimeString()}.";
            }
            else if (userMessage.Contains("onde você está?"))
            {
                botResponse = "Eu vivo na nuvem! 🌩️";
            }
            else
            {
                // Se nenhuma condição foi atendida, pergunta à IA Gemini
                botResponse = await GetGeminiResponse(userMessage);
            }

            // Enviar a resposta para o usuário
            await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: botResponse
            );
        }
    }

    // Método para lidar com erros
    private static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        var ErrorMessage = exception switch
        {
            ApiRequestException apiRequestException => $"Erro na API do Telegram:\n{apiRequestException.ErrorCode}\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        Console.WriteLine(ErrorMessage);
        return Task.CompletedTask;
    }

    // Método para obter a resposta da Gemini AI
    private static async Task<string> GetGeminiResponse(string userInput)
    {
        try
        {
            // Configure o nome do projeto e outras informações
            string projectId = "SEU_PROJECT_ID"; // Substitua pelo ID do seu projeto
            string location = "us-central1"; // Região onde o serviço está disponível
            string modelId = "text-bison@001"; // Modelo a ser utilizado (ajuste se necessário)

            // Crie o cliente do Vertex AI
            PredictionServiceClient predictionClient = await PredictionServiceClient.CreateAsync();

            // Construa o nome do modelo
            ModelName modelName = new ModelName(projectId, location, modelId);

            // Prepare a instância de entrada
            var instance = new Struct
            {
                Fields = { ["content"] = Value.ForString(userInput) }
            };

            // Prepare os parâmetros (opcional)
            var parameters = new Struct
            {
                Fields =
                {
                    ["temperature"] = Value.ForNumber(0.7),
                    ["maxOutputTokens"] = Value.ForNumber(256),
                    ["topP"] = Value.ForNumber(0.8),
                    ["topK"] = Value.ForNumber(40)
                }
            };

            // Faça a chamada de predição
            PredictResponse response = await predictionClient.PredictAsync(
                modelName,
                new[] { instance },
                parameters
            );

            // Processar a resposta
            foreach (var prediction in response.Predictions)
            {
                var content = prediction.Fields["content"].StringValue;
                return content.Trim();
            }

            return "Desculpe, não consegui gerar uma resposta.";
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro ao chamar a API do Vertex AI: {e.Message}");
            return "Desculpe, ocorreu um erro ao processar sua solicitação.";
        }
    }
}
