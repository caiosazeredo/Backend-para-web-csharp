// Corpo do programa
Console.WriteLine("Olá, Mundo!"); // Imprime uma mensagem no console

// Exemplo de declaração de variáveis
int numero = 42; // Declaração de uma variável inteira
int numero2 = 22; // Declaração de uma variável inteira
string mensagem = "Este é um exemplo de estrutura básica."; // Declaração de uma variável de string

int soma = numero + numero2;

if (soma> 70)
{

    Console.WriteLine("Financiamento aprovado");
}
else
{
    Console.WriteLine("Financiamento não aprovado!");
}

// Exibindo valores no console
Console.WriteLine("A soma de "
    + numero + " + " + numero2 + "é: " + soma);
Console.WriteLine(mensagem);

// Mantém a janela do console aberta até que uma tecla seja pressionada
Console.ReadKey();
