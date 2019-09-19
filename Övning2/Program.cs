using System;

namespace Övning2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Användaren skriver in decimaltal
           Console.Write("Skriv in ett decimaltal:");
           double tal=Convert.ToDouble(Console.ReadLine());
            
            //Convertar till heltal
           int tal1=Convert.ToInt16(tal+0.01);

           //Skriver ut heltalet
           Console.WriteLine("Ditt tal avrunat till närmsta heltal är: "+tal1);

        }
    }
}
