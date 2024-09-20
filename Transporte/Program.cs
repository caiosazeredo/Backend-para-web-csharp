
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Solicitar Taxi");
        Console.WriteLine("2 - Solicitar Uber");
        Console.WriteLine("3 - Solicitar Uber Moto");

        string opcao = Console.ReadLine();
        switch (opcao)
        {
            case "1":
                Console.WriteLine("Taxi solicitado com sucesso!");
                break;
            case "2":
                Console.WriteLine("Uber solicitado com sucesso!");
                break;
            case "3":
                Console.WriteLine("Uber Moto solicitado com sucesso!");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }

        Console.WriteLine("\nPressione Enter para sair.");
        Console.ReadLine();
