namespace ExemplosConstrutores.Models
{
    public class Calculadora
    {
        //Delagate
        public delegate void DelegateCalculadora();
        //Evento
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int a, int b)
        {
            if (EventoCalculadora != null)
            {
                System.Console.WriteLine($"Adição: {a + b}");
                EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }
            
        }
        public static void Subtrair(int a, int b)
        {
            System.Console.WriteLine($"Subtração: {a - b}");
        }
    }
}