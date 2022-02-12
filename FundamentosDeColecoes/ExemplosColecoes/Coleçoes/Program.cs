using System;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[10];

            arrayInteiros[8] = 3510;
            arrayInteiros[0] = 4560;
            arrayInteiros[9] = 5000;

            System.Console.WriteLine("Percorrendo array pelo for");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                System.Console.WriteLine(arrayInteiros[i]);
            }

            System.Console.WriteLine("Percorrendo array pelo foreach");
            foreach (var item in arrayInteiros)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}
