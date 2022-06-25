public class Codigo
{
public static void CalcularSoma()
{
    double a, b, resultado;
    
    Console.Clear();
    Console.Beep();

    Console.ForegroundColor = ConsoleColor.DarkBlue;

    Console.WriteLine("--- Soma A+B ---\n");
    Console.WriteLine("Digite os valores.");
    Console.ResetColor();

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = Aritmetica.Soma(a,b);

    Console.Clear();
    Console.Beep();
     Console.WriteLine($"{a} somado com {b} é {resultado}");
    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

 public static void CalcularPorcentagem()
 {
     decimal porcentagem, numero, Resultado;
     
     Console.Clear();
    Console.Beep();

    Console.ForegroundColor = ConsoleColor.DarkBlue;

     Console.WriteLine("--- Porcentagem A%B ---\n");
    Console.WriteLine("Digite os valores.");
    Console.ResetColor();
    Console.ResetColor();

    Console.Write("Porcentagem = ");
    porcentagem = Convert.ToDecimal(Console.ReadLine());

    Console.Write("numero = ");
    numero = Convert.ToDecimal(Console.ReadLine());

    Resultado = Aritmetica.Porcentagem(porcentagem, numero);

    Console.Clear();
    Console.Beep();
    Console.WriteLine($"{porcentagem}% de {numero} é:{Resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
 }

public static void CalcularSubtracao()
{
    double a, b, resultado;

   Console.Clear();
   Console.Beep();

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    
    Console.WriteLine("--- Subtração A-B ---\n");
    Console.WriteLine("Digite os valores.");
    Console.ResetColor();

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = Aritmetica.Subtracao(a,b);

    Console.Clear();
    Console.Beep();
    Console.WriteLine($"{a} subtraindo {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

public static void CalcularMultiplicacao()
{
    double a, b, resultado;

   Console.Clear();
   Console.Beep();

    Console.ForegroundColor = ConsoleColor.DarkBlue;

    Console.WriteLine("--- Multiplicação A*B ---\n");
    Console.WriteLine("Digite os valores.");
    Console.ResetColor();

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

    resultado = Aritmetica.Multiplicacao(a,b);

    Console.Clear();
    Console.Beep();
    Console.WriteLine($"{a} multiplicado por {b} é {resultado}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

public static void  CalcularDivisao()
{
    double a, b, resultado;

    Console.Clear();
    Console.Beep();
     Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("--- Divisão A/B ---\n");
    Console.WriteLine("Digite os valores.");
    Console.ResetColor();

    Console.Write("A = ");
    a = Convert.ToDouble(Console.ReadLine());
    Console.Write("B = ");
    b = Convert.ToDouble(Console.ReadLine());

        resultado = Aritmetica.Divisao(a,b);

        
        Console.Clear();
        Console.Beep();
        Console.WriteLine($"{a} dividido por {b} é {resultado}");
        

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
}

public static void CalcularBhaskara()
{
    Console.Clear();
    Console.Beep();

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("--- Bhaskara A²+B+C ---\n");
    Console.WriteLine("Digite os valores.");
    Console.ResetColor();
    
    double a, b ,c, delta, x1, x2;

Console.Write("(a):");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("(b):");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("(c):");
c = Convert.ToDouble(Console.ReadLine());

delta = Math.Pow(b,2) -4 * a *c;
if (a == 0)
{
    Console.Clear();
    Console.Beep();
    Console.ForegroundColor=  ConsoleColor.Yellow;
    Console.WriteLine("Não é uma equação de segundo grau!");
        Console.ResetColor();
}
else if (delta < 0)
{
   Console.Clear();
   Console.Beep();
    Console.ForegroundColor=  ConsoleColor.DarkRed;
    Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais!");
    Console.ResetColor();
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    
    Console.Clear();
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"x1 ={x1:N2} e x2 ={x2:N2}");
    Console.ResetColor();
}

 Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

}
public static void CalcularExponenciação()
{
double numero,  potencia, expoente;

    Console.Clear();
    Console.Beep();

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("--- Exponenciação A²---\n");
    Console.WriteLine("Digite os valores.");
    Console.ResetColor();

Console.Write("(a):");
numero = Convert.ToDouble(Console.ReadLine());


Console.Write("(Expoente):");
expoente =  Convert.ToDouble(Console.ReadLine());

potencia = Aritmetica.Exponenciacao(numero, expoente);


Console.Clear();
Console.Beep();
Console.WriteLine($"{numero} ao quadrado é:{potencia}");

Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
}

    
    public static void CalcularRadiciação()
    {
        double radicando,  indice, raiz;

    Console.Clear();
    Console.Beep();

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("--- Radiciação √A ---\n");
    Console.WriteLine("Digite os valores.");
    Console.ResetColor();

    Console.Write("(radicando):");
    radicando = Convert.ToDouble(Console.ReadLine());

    Console.Write("(índice):");
    indice =  Convert.ToDouble(Console.ReadLine());

    raiz = Aritmetica.Radiciacao(radicando,indice);

    Console.Clear();
    Console.Beep();
    Console.WriteLine($"A raiz de {radicando} é {raiz}");

    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();

    return;
    }
}