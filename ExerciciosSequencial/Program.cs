using System;
using System.Globalization;

namespace ExerciciosSequencial // 
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("1 : Soma de 2 Numeros");
            Console.WriteLine("2 : Area de um circulo");
            Console.WriteLine("3 : Diferença entre produtos");
            Console.WriteLine("4 : Calcular sálario de funcionário");
            Console.WriteLine("5 : Valor total a pagar de 2 peças");
            Console.WriteLine("6 : Areas de formas geométricas");
            Console.Write("\nOpção:");
            int op = int.Parse(Console.ReadLine());
            Console.Clear();
            const float pi = 3.14159f;
            switch (op) {
                case 1:

                    Console.WriteLine("Digite os numeros para somar!");
                    Console.Write("Primeiro Número: ");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.Write("\nSegundo Número: ");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nSOMA = {n1 + n2}");
                    break;
                case 2:
                    Console.Write("Digite o raio do cirulo:");
                    float r = float.Parse(Console.ReadLine());
                    Console.WriteLine($"\nAREA = {(Math.Pow(r, 2) * pi).ToString("F4", CultureInfo.InvariantCulture)}");
                    break;
                case 3:
                    Console.WriteLine("Digite os valores de A, B, C e D para calcular a diferença entre o produto dos 2 primeiros com o produto dos 2 ultimos:");
                    Console.Write("A: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("\nB: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.Write("\nC: ");
                    int c = int.Parse(Console.ReadLine());
                    Console.Write("\nD: ");
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nDIFERENÇA = {(a * b) - (c * d)}");
                    break;
                case 4:
                    Console.Write("Digite o numero do funcionário: ");
                    int num = int.Parse(Console.ReadLine());
                    Console.Write("\nDigite o numero de horas trabalhadas: ");
                    int hrs = int.Parse(Console.ReadLine());
                    Console.Write("\nDigite o valor que recebe por hora: ");
                    float sal = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine($"\nNUMBER = {num}");
                    Console.WriteLine($"SALARY = {(hrs*sal).ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 5:
                    Console.WriteLine("Digite, separados por espaço, o codigo da peça, o numero de peças desejadas e o preço unitário(ex: 13 2 15.30): ");
                    Console.WriteLine("Peça 1: ");
                    string[] p1 = Console.ReadLine().Split(' ');
                    Console.WriteLine("\nPeça 2: ");
                    string[] p2 = Console.ReadLine().Split(' ');
                    float val1 = int.Parse(p1[1]) * float.Parse(p1[2],CultureInfo.InvariantCulture);
                    float val2 = int.Parse(p2[1]) * float.Parse(p2[2], CultureInfo.InvariantCulture);
                    Console.WriteLine($"\nVALOR A PAGAR R${(val1 + val2).ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case 6:
                    Console.WriteLine("Digite, separado por espaço, 3 valores flutuantes para calcular a area(ex: 3.57 4.78 10.87):");
                    string[] ponto = Console.ReadLine().Split(' ');
                    float A = float.Parse(ponto[0], CultureInfo.InvariantCulture);
                    float B = float.Parse(ponto[1], CultureInfo.InvariantCulture);
                    float C = float.Parse(ponto[2], CultureInfo.InvariantCulture);
                    Console.WriteLine($"TRIANGULO: {((A*C)/2).ToString("F3",CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"CIRCULO: {(Math.Pow(C, 2) * pi).ToString("F3", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"TRAPEZIO: {(((A+B)*C)/2).ToString("F3", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"QUADRADO: {(Math.Pow(B, 2)).ToString("F3", CultureInfo.InvariantCulture)}");
                    Console.WriteLine($"RETANGULO: {(A*B).ToString("F3", CultureInfo.InvariantCulture)}");
                    break;
                default:
                    break;
            }


        }
    }
}
