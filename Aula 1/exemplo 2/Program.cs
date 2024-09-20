Console.WriteLine("Senac Warriors");

Console.Write("Digite A Classe desejada: \n 1- Bardo \n 2- arqueiro \n 3- arqueiro \n 4- mago \n");
int selecao = Convert.ToInt32(Console.ReadLine());

if (selecao == 1)
{
    Console.WriteLine("Você selecionou Bardo" + " ao escolher opção: " + selecao);
}
else if (selecao == 2)
{
    Console.WriteLine("Você selecionou arqueiro" + " ao escolher opção: " + selecao);
}
else if (selecao == 3)
{
    Console.WriteLine("Você selecionou guerreiro" + " ao escolher opção: " + selecao);
}
else if (selecao == 4)
{
    Console.WriteLine("Você selecionou mago"+ " ao escolher opção: " +selecao);
}
else
{
    Console.WriteLine("Opção invalida");
}
Console.ReadKey();

