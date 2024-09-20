
Console.Write("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());
double numeroNovo;
if (numero % 3 == 0)
{
    numeroNovo = numero * 5;
    Console.WriteLine("Como é divisível por 3, multiplicamos por 5 e ele virou:" + numeroNovo);
}
else
{
    numeroNovo = numero * 3;
    Console.WriteLine("Como não é divisível por 3, multiplicamos por 3 e ele virou:" + numeroNovo);
}

// Mantém a janela do console aberta
Console.ReadKey();
        
