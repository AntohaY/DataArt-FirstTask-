using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal first_number;
            decimal second_number;
            string stringInput;
            string stringInput_2;
            Console.WriteLine("Enter first number");
            try
            {    
                //
                stringInput = Console.ReadLine();
//              
                while (!decimal.TryParse(stringInput, out first_number))
                {
                    Console.WriteLine("Incorrect input !");
                    Console.Write("Enter first number :");
                    stringInput = Console.ReadLine();
                }
                Console.WriteLine("Your first number :" + first_number);
                //
                Console.WriteLine("Enter second number");

                stringInput_2 = Console.ReadLine();

                while (!decimal.TryParse(stringInput_2, out second_number))
                {
                    Console.WriteLine("Incorrect input !");
                    Console.Write("Enter second number: ");
                    stringInput = Console.ReadLine();
                }
                Console.WriteLine("Your second number :" + second_number);


                Console.WriteLine("Select desired action: " + "+" + " " + "-" + " " + "*" + " " + "/");

                 string action = Convert.ToString(Console.ReadLine());

                switch (action)
                {
                    case "+":
                        Console.Write(first_number + second_number);
                        break;
                    case "-":
                        Console.Write(first_number - second_number);
                        break;
                    case "*":
                        Console.Write(first_number * second_number);
                        break;
                    case "/":
                        try
                        {
                            Console.Write(first_number / second_number);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Perhaps you divided by zero.Why?");
                        }
                        break;
                    default:
                        Console.WriteLine(":(");
                        break;
                       
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
