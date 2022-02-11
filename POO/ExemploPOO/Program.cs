using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1");
            var caminhoArquivos = Path.Combine(caminho, "arquivo-teste-stream.txt");
            var caminhoArquivosTeste = Path.Combine(caminho, "arquivo-teste.txt");
            var caminhoArquivosTesteCopia = Path.Combine(caminho, "arquivo-teste-backup.txt");
            var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
            var novoCaminhoarqv = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");

            FileHelper Helper = new FileHelper();
            Helper.deletarArquivo(caminhoArquivosTesteCopia);
            // Helper.copiarArquivo(caminhoArquivosTeste, caminhoArquivosTesteCopia, false);
            // Helper.moverArquivo(caminhoArquivos, novoCaminhoarqv, false);
            // Helper.LerArquivoStream(caminhoArquivos);
            // Helper.CriarArquivoTextoStream(caminhoArquivos, listaString);
            // Helper.AdicionarTextoStream(caminhoArquivos, listaStringContinuacao);
            // Helper.CriarArquivos(caminhoArquivos, "Olá, meus parças!");
            // Helper.ApagarDiretorios(caminhoPathCombine, true);
            // System.Console.WriteLine("Criando Diretórios: " + caminhoPathCombine);
            // Helper.CriarDiretorios(caminhoPathCombine);
            // Helper.ListarArquivosDiretorios(caminho);
            // Helper.ListarDiretorio(caminho);
            
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Dividir(40,4));

            
            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();
            
            
            // Calculadora calc = new Calculadora ();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));
            
            //  Aluno a1 = new Aluno();
            //  a1.Nota = 10;
            //  a1.Name = "Bob";
            //  a1.idade = 20;

            //  a1.Apresentar();

            // Professor p1  = new Professor();
            //  p1.salario = 5000;
            //  p1.Name = "Jeffrey";
            //  p1.idade = 50;

            //  p1.Apresentar();

             
            // Valores válidos
            // retangulo r = new retangulo();
            // r.DefinirMedidas(-30, 30);

            // System.Console.WriteLine($"Área: {r.ObterArea()}");


            // Pessoa p1 = new Pessoa();

            // p1.Name = "Bob";
            // p1.idade = 20;

            // p1.Apresentar();
        }
    }
}