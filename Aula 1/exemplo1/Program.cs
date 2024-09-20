// Tipos Nulos (Nullable Types)
int? numeroInteiroNulo = null;
double? numeroDoubleNulo = null;

// Tipos Complexos
DateTime dataAtual = DateTime.Now;
TimeSpan intervalo = TimeSpan.FromHours(1);
Guid identificadorUnico = Guid.NewGuid();

// Vetores (Arrays)
int[] arrayInteiros = new int[] { 1, 2, 3, 4, 5 };
string[] arrayStrings = new string[] { "Um", "Dois", "Três" };

// Listas
var listaInteiros = new System.Collections.Generic.List<int> { 1, 2, 3, 4, 5 };
var listaStrings = new System.Collections.Generic.List<string> { "Um", "Dois", "Três" };

// Tuplas
var tupla = (nome: "John Doe", idade: 30, ativo: true);

// Dinâmico (dynamic)
dynamic valorDinamico = 1;
valorDinamico = "Agora sou uma string";

// Constantes
const double pi = 3.14159;
const string saudacao = "Olá";

// Variáveis implícitas
var numeroImplicito = 42; // tipo int inferido
var textoImplicito = "Texto"; // tipo string inferido


Console.WriteLine($"Número Inteiro Nulo: {numeroInteiroNulo}");
Console.WriteLine($"Número Double Nulo: {numeroDoubleNulo}");
Console.WriteLine($"Data Atual: {dataAtual}");
Console.WriteLine($"Intervalo: {intervalo}");
Console.WriteLine($"GUID: {identificadorUnico}");
Console.WriteLine($"Array de Inteiros: {string.Join(", ", arrayInteiros)}");
Console.WriteLine($"Array de Strings: {string.Join(", ", arrayStrings)}");
Console.WriteLine($"Lista de Inteiros: {string.Join(", ", listaInteiros)}");
Console.WriteLine($"Lista de Strings: {string.Join(", ", listaStrings)}");
Console.WriteLine($"Tupla: Nome = {tupla.nome}, Idade = {tupla.idade}, Ativo = {tupla.ativo}");
Console.WriteLine($"Valor Dinâmico: {valorDinamico}");
Console.WriteLine($"Constante Pi: {pi}");
Console.WriteLine($"Constante Saudação: {saudacao}");
Console.WriteLine($"Número Implícito: {numeroImplicito}");
Console.WriteLine($"Texto Implícito: {textoImplicito}");

Console.ReadKey();
