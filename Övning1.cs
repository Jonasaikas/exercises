using System;

namespace exercises_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange två tal!"); 

            Console.Write("Tal 1:"); 
            int tal1=Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Tal 2:"); 
            int tal2=Convert.ToInt32(Console.ReadLine()); 

            int sum=tal1+tal2; 

            Console.WriteLine("Summan av dina tal blir: "+sum); 
        }
    }
}
