using ExemplosConstrutores.Models;
namespace ExemplosConstrutores
{
    class Program
    {
        public delegate void Operacao(int a, int b);
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();

            
            //Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            // op.Invoke(400, 400);
            // op.Invoke(56, 78);


            // const double pi = 3.14;
            // System.Console.WriteLine(pi);


            // Data data = new Data();
            // //data.SetMes(20);

            // data.Mes = 12;
            // System.Console.WriteLine(data.Mes);

            // data.ApresentarMes();

            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste Instância";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);
            
            // Pessoa p1 = new Pessoa();
            // p1.Apresentar();

            // Aluno p1 = new Aluno("Elisa", "Estigarraga", "Filosofia");
            // p1.Apresentar();
        }
    }
}        

