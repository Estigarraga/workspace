namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }

         public override void Apresentar()
       {
           Console.WriteLine($"Olá meu nome é {Name}, tenho {idade} anos e ganho {salario} dólares");
       }
    }
}