using System;
using System.Collections.Generic;
using System.IO;

class Auto
{
    public int HP;
    public string Color;
    protected List<string> historial = new List<string>();

    public Auto(int hp, string color)
    {
        HP = hp;
        Color = color;
    }

    public virtual void Reparar() { }
    public virtual void Historia() { }
}

class BMW : Auto
{
    string modelo;
    string ruta = "reparaciones.txt";

    public BMW(int hp, string color, string modelo) : base(hp, color)
    {
        this.modelo = modelo;
    }

    public override void Reparar()
    {
        string texto = $"BMW {modelo} reparado {DateTime.Now}";
        historial.Add(texto);
        File.AppendAllText(ruta, texto + "\n");
        Console.WriteLine("Reparado!");
    }

    public override void Historia()
    {
        if (File.Exists(ruta))
            foreach (var l in File.ReadAllLines(ruta))
                Console.WriteLine(l);
        else
            Console.WriteLine("Sin historial");
    }
}

class Program
{
    static void Main()
    {
        BMW auto = new BMW(300, "Rojo", "M3");
        int op;

        do
        {
            Console.WriteLine("\n1. Reparar");
            Console.WriteLine("2. Ver historial");
            Console.WriteLine("3. Salir");
            Console.Write("Opcion: ");
            op = int.Parse(Console.ReadLine());

            Console.Clear();

            if (op == 1) auto.Reparar();
            if (op == 2) auto.Historia();

        } while (op != 3);
    }
}
