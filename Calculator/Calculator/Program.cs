using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Calculator");
            Console.WriteLine("==================");

            Console.WriteLine("Birinci ededi secin:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("===============");

            Console.WriteLine("Ikinci ededi secin:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("================");

            int choise;

            do
            {
                Console.WriteLine("Emeliyyat secin:");
                Console.WriteLine("\t1-Toplama");
                Console.WriteLine("\t2-Vurma");
                Console.WriteLine("\t3-Cixma");
                Console.WriteLine("\t4-Bolme");
                Console.WriteLine("\t5-Cixis");
                choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine($"Cavab: {num1} + {num2} = " + (num1+num2));
                        break;
                    case 2:
                        Console.WriteLine($"Cavab: {num1} * {num2} = " +(num1*num2));
                        break;
                    case 3:
                        Console.WriteLine($"Cavab: {num1} - {num2} = " + (num1 - num2));
                        break;
                    case 4:
                        Console.WriteLine($"Cavab: {num1} / {num2} = " + (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine("Saqolun");
                        break;
                    default:
                        break;
                }
            } while (choise != 5);
        }
    }
}
