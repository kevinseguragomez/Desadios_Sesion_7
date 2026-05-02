using System;

class Calculadora
{
    public string Marca;
    public string Serie;

    public double Sumar(double a, double b) => a + b;
    public double Restar(double a, double b) => a - b;
    public double Multiplicar(double a, double b) => a * b;
    public double Dividir(double a, double b) => b != 0 ? a / b : 0;
}

class CalculadoraCientifica : Calculadora
{
    public double Potencia(double a, double b) => Math.Pow(a, b);
    public double Raiz(double a) => Math.Sqrt(a);
    public double Modulo(double a, double b) => a % b;
    public double Logaritmo(double a) => Math.Log(a);
}

class Program
{
    static void Main()
    {
        Calculadora calc = new Calculadora();
        CalculadoraCientifica calcC = new CalculadoraCientifica();

        Console.WriteLine("Suma: " + calc.Sumar(5, 3));
        Console.WriteLine("Multiplicar: " + calc.Multiplicar(4, 2));

        Console.WriteLine("Potencia: " + calcC.Potencia(2, 3));
        Console.WriteLine("Raiz: " + calcC.Raiz(16));
    }
}
