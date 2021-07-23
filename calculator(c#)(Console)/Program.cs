using System;
//made by TopperTom
namespace TomsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display
            Console.Title = "Calclator";
            Console.ForegroundColor = ConsoleColor.Green;
            //Welcome
            Console.WriteLine("Welcome to calculator\nMade by Tom Harrison!");
            //Calclator
            string cal;
            Double num01;
            Double num02;
            
            Console.WriteLine("Type x=multiplication +=addition -=subtraction /=devision");
            Console.Write("TYPEHERE: ");
            cal = Convert.ToString( Console.ReadLine() );

            if (cal == "x")
            {
                goto multiply;
            }
            if (cal == "+")
            {
                goto add;
            }
            if (cal == "-")
            {
                goto subtract;
            }
            if (cal == "/")
            {
                goto devide;
            }
            goto exit;

            //Addition
            add:
            Console.Write("Input a number: "); 
            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            Double result = num01 + num02;
            Console.WriteLine("Answer = " + result);
            goto exit;

            //Subtraction
            subtract:
            Console.Write("Input a number: "); 
            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            Double result1 = num01 - num02;
            Console.WriteLine("Answer = " + result1);
            goto exit;

            //Devision
            devide:
            Console.Write("Input a number: "); 
            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            Double result2 = num01 / num02;
            Console.WriteLine("Answer = " + result2);
            goto exit;

            //Multiply
            multiply:
            Console.Write("Input a number: "); 
            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            Double result3 = num01 * num02;
            Console.WriteLine("Answer = " + result3);

           //Wait before close
            exit:
            Console.ReadKey();
        }
    }
}
