internal class Program
{
    private static void Main(string[] args)
    {
        int numero1;
        int numero2;
        int resultado;
        Console.WriteLine("Dime un numero: ");
        numero1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Dime otro numero: ");
        numero2=Convert.ToInt32(Console.ReadLine());

        resultado=numero1+numero2;

        Console.WriteLine("La suma de {0} + {1} da un resultado de {2}", numero1,numero2,resultado);
    }
}