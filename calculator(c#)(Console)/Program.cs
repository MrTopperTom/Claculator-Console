using System;
namespace Calculator NOT Claculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display
            Console.Title = "Calclator";
            Console.ForegroundColor = ConsoleColor.Green;
            //Welcome
            Console.WriteLine("Welcome!");
            //Calclator
            string cal;
            Double num01;
            Double num02;
            
            start:
            Console.WriteLine("Type x for multiplication | '+' for addition | '-' for subtraction | '/' for devision - don't include single-quoted speech marks");
            Console.Write("Input: ");
            cal = Convert.ToString(Console.ReadLine());

            if (cal == "x")
            {
                goto multiply;
            }
            else if (cal == "+")
            {
                goto add;
            }
            else if (cal == "-")
            {
                goto subtract;
            }
            else if (cal == "/")
            {
                goto devide;
            }
            goto invalid;
            
            invalid:
            Console.Clear() 
            Console.WriteLine("INVALID entry.\n");
            Console.WriteLine("Do you want to continue? ");
            Console.Write("Input: ");
            input = Convert.ToString(Console.ReadLine());
                if (input == "yes") {   
                    Console.WriteLine("OK. Press any key to continue...");
                    Console.ReadKey();
                    goto start;
                }
                else {
                   goto exit;
             
                }
            
            //invalid
            
            //Addition
            add:
            Console.Write("Input a number: "); 
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Double result = num01 + num02;
            Console.WriteLine("Answer = " + result);
            goto exit;

            //Subtraction
            subtract:
            Console.Write("Input a number: "); 
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Double result1 = num01 - num02;
            Console.WriteLine("Answer = " + result1);
            goto exit;

            //Devision
            devide:
            Console.Write("Input a number: "); 
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Double result2 = num01 / num02;
            Console.WriteLine("Answer = " + result2);
            goto exit;

            //Multiply
            multiply:
            Console.Write("Input a number: "); 
            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            Double result3 = num01 * num02;
            Console.WriteLine("Answer = " + result3);

           //Wait before close
            exit:
            Console.ReadKey();
        }
    }
}
