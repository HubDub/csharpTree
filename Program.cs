using System;

namespace ConsoleApplication
{
    public class Program
    {
        static void MakeTree(string Symbol, int Height)
        {
            for(int i=1; i<=Height; i++)
            {
                for(int j=i; j<=Height-1; j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=i*2-1; k++)
                {
                Console.Write(Symbol);
                }
                Console.WriteLine(" ");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter the symbol you want to make the tree out of:");
            string Symbol = Console.ReadLine();
            Console.WriteLine("How many layers do you want in your tree?");
            int Height = Int32.Parse(Console.ReadLine());
            MakeTree(Symbol, Height);
        }
    }
}
