string opcaoDesejada;

Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("--- Calculadora 8 operações ---\n");
Console.ResetColor();
Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[%] Porcentagem");
Console.WriteLine("[b] Bhaskara");
Console.WriteLine("[e] Esponenciação");
Console.WriteLine("[r] Radiciação");
Console.WriteLine("[s] Sair");


Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        Codigo.CalcularSoma();
        break;
    case "-":
        Codigo.CalcularSubtracao();
        break;
    case "*":
        Codigo.CalcularMultiplicacao();
        break;
    case "/":
        Codigo.CalcularDivisao();
        break;
     case "%":
        Codigo.CalcularPorcentagem();
        break;
    case "b":
        Codigo.CalcularBhaskara();
        break;
    case "e":
        Codigo.CalcularExponenciação();
        break;
    case "r":
        Codigo.CalcularRadiciação();
        break;
    case"s":
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
    
}

Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("\nObrigado por utilizar meu programa.");
Console.WriteLine("\nNome: João Pedro ");
Console.WriteLine("\nGitHub: JoaoPedroCordoba\n");
Console.ResetColor();
