using System;

namespace Take_Two_Stones
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            num = Convert.ToDouble(Console.ReadLine());
            num = num - 2;
            if((num % 2) == 0){
                Console.WriteLine("Bob");
            }
            else{
                Console.WriteLine("Alice");
            }
        }
    }
}
