public class Aritmetica
{
    public static double Soma(double parcela1, double parcela2)
    {
        double total = parcela1 + parcela2;
        return total;
    }
        public static double Subtracao(double minuendo, double subtraendo)
    {
        double diferenca = minuendo - subtraendo;
        return diferenca;
    }

    public static double Multiplicacao(double fator1, double fator2)
    {
        double produto = fator1 * fator2;
        return produto;
    }
     public static double Divisao(double dividendo, double divisor )

     { if (divisor == 0)
    {
        throw new Exception("Não é possível dividir por zero.");
    }
    double quociente  = dividendo / divisor;
    return quociente;
     }

    public static decimal Porcentagem(decimal  porcentagem,  decimal numero )
    {
        decimal resultado = porcentagem /100 * numero;
        return resultado;
    }

    public static double Bhaskara(double a , double b, double c, double delta, double x1, double x2)
    {
       delta =  Math.Pow(b,2) -4 * a *c;
if (a == 0)
{
    
    Console.ForegroundColor=  ConsoleColor.Yellow;
    Console.WriteLine("Não é uma equação de segundo grau!");
        Console.ResetColor();
}
else if (delta < 0)
{
    Console.ForegroundColor=  ConsoleColor.DarkRed;
    Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais!");
    Console.ResetColor();
}
else
{
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    
    
    Console.WriteLine($"x1 ={x1:N2} e x2 ={x2:N2}");
}
    Console.WriteLine("\nPressione uma tecla para continuar...");
    Console.ReadKey();
         return x1;

    }

    public static double Exponenciacao(double numero, double expoente)
    {
        double potencia = Math.Pow(numero,expoente);
        return potencia;
    }

    public static double Radiciacao(double radicando, double indice)
    {
        double raiz = Math.Pow( radicando, 1/indice);
        return raiz;
        
    }


}
