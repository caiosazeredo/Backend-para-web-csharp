using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Exceptions;


class Program
{
    // Coloque seu token do bot aqui
    private static readonly string BotToken = "7515761321:AAFTehnYBnRsKcyR2j9QlbvmeuPO0rkphvw";
    private static TelegramBotClient botClient;

    static void Main(string[] args)
    {
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

            Console.WriteLine($"Recebi uma mensagem de {message.Chat.FirstName}: {message.Text}");

            // Verificar perguntas sobre o Rio de Janeiro
            string resposta = ProcessarPerguntaSobreRio(message.Text.ToLower());

            // Enviar a resposta para o usuário
            await botClient.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: resposta
            );
        }
    }


    // Método para processar perguntas relacionadas ao Rio de Janeiro
    private static string ProcessarPerguntaSobreRio(string pergunta)
    {
        if (pergunta.Contains("cristo redentor"))
        {
            return "O Cristo Redentor é uma estátua de Jesus Cristo localizada no topo do Corcovado, no Rio de Janeiro.";
        }
        else if (pergunta.Contains("ola") ||
                pergunta.Contains("oi") ||
                pergunta.Contains("bom dia") ||
                pergunta.Contains("boa tarde") ||
                pergunta.Contains("boa noite") ||
                pergunta.Contains("saudações") ||
                pergunta.Contains("e aí") ||
                pergunta.Contains("olá"))
        
            {
            return "opa, tudo bem?";
        }
        else if (pergunta.Contains("aquario"))
            { 
            return ("");
        }
        else
        {
            return "Ih rapazzz, não sei nada sobre isso não";
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
}
