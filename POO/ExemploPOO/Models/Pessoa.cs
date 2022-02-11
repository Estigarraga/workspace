namespace ExemploPOO.Models
{
    public class Pessoa
    {
       public string Name { get; set; }

       public int idade { get; set; }

       public void Apresentar()
       {
           Console.WriteLine($"Olá meu nome é {Name} e tenho {idade} anos");
       }
    }
}