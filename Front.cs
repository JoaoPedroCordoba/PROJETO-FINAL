string opcaoDesejada;

Console.Clear();

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("[+] Soma");
Console.WriteLine("[-] Subtração");
Console.WriteLine("[*] Multiplicação");
Console.WriteLine("[/] Divisão");
Console.WriteLine("[%] Porcentagem");

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
    default:
        Console.WriteLine("Opção inválida.");
        break;
    
}

Console.WriteLine("\nObrigado por utilizar nosso programa.");