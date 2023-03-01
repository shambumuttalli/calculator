using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpel_calculator
{
    class Program
    {
        static void Main(string[] args)

        { string a;
            do
            {

                int res;
                Console.WriteLine("enter the first number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the symbol(/,*,-,+,%)");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("addition:" + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("substraction:" + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("multtiplication:" + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("divition:" + res);
                        break;
                    case "%":
                        res = num1 % num2;
                        Console.WriteLine("madulas:" + res);
                        break;
                    default:
                        Console.WriteLine("wrong out input");
                        break;
                }
                Console.ReadKey();
                Console.WriteLine("do u want to continue :( Y / y)");
                a = Console.ReadLine();
            }
            while
            (a == "Y" || a == "y");
          }  
        
    }
}
