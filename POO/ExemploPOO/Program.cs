using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valores válidos
            retangulo r = new retangulo();
            r.DefinirMedidas(-30, 30);
            
            System.Console.WriteLine($"Área: {r.ObterArea()}");
            
            
            
            
            
            // Pessoa p1 = new Pessoa();

            // p1.Name = "Bob";
            // p1.idade = 20;

            // p1.Apresentar();
        }
    }
}