using System;

namespace _03_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal accBalance = 300;
            bool estCrediteur = accBalance >= 0;
            if (estCrediteur)
                Console.WriteLine("Votre compte est créditeur");
            else
                Console.WriteLine("Votre compte est débiteur");
        }
    }
}
