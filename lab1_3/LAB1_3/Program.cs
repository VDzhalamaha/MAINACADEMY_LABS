using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            4. Guess the Number
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                case 4:
                    Gues_the_number();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle()
        {


            string leftBank = "fcwg";
            string rightBank = "";
            int choice;

            while (rightBank.Length != 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
                At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
                a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
                You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
                if (leftBank.IndexOf("f") != -1)
                {
                    Console.WriteLine("1:farmer --> right bank");
                    if (leftBank.IndexOf("w") != -1)
                    {
                        Console.WriteLine("2:farmer and wolf-->  right bank");
                    }
                    if (leftBank.IndexOf("g") != -1)
                    {
                        Console.WriteLine("3:farmer and goat-->  right bank");
                    }
                    if (leftBank.IndexOf("c") != -1)
                    {
                        Console.WriteLine("4:farmer and cabbage-->  right bank");
                    }
                }

                if (rightBank.IndexOf("f") != -1)
                {
                    Console.WriteLine("5: left bank <-- farmer ");
                    if (rightBank.IndexOf("w") != -1)
                    {
                        Console.WriteLine("6:left bank <-- farmer and wolf");
                    }
                    if (rightBank.IndexOf("g") != -1)
                    {
                        Console.WriteLine("7:left bank <-- farmer and goat");
                    }
                    if (rightBank.IndexOf("c") != -1)
                    {
                        Console.WriteLine("8:left bank <-- farmer and cabbage");
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please,  type numbers by step ");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        leftBank = leftBank.Replace("f", "");
                        rightBank = rightBank + "f";
                        if (leftBank.IndexOf("c") != -1 & leftBank.IndexOf("g") != -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("you can't leave together goat and cabage! ");
                            rightBank = rightBank.Replace("f", "");
                            leftBank = leftBank + "f";
                            Console.ReadLine();
                        }
                        if (leftBank.IndexOf("w") != -1 & leftBank.IndexOf("g") != -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("you can't leave together goat and wolf! ");
                            rightBank = rightBank.Replace("f", "");
                            leftBank = leftBank + "f";
                            Console.ReadLine();
                        }
                        break;
                    case 2:
                        leftBank = leftBank.Replace("f", "");
                        leftBank = leftBank.Replace("w", "");
                        rightBank = rightBank + "fw";
                        if (leftBank.IndexOf("c") != -1 & leftBank.IndexOf("g") != -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("you can't leave together goat and cabage! ");
                            rightBank = rightBank.Replace("f", "");
                            rightBank = rightBank.Replace("w", "");
                            leftBank = leftBank + "fw";
                            Console.ReadLine();
                        }
                        break;
                    case 3:
                        leftBank = leftBank.Replace("f", "");
                        leftBank = leftBank.Replace("g", "");
                        rightBank = rightBank + "f";
                        rightBank = rightBank + "g";

                        break;
                    case 4:
                        leftBank = leftBank.Replace("f", "");
                        leftBank = leftBank.Replace("c", "");
                        rightBank = rightBank + "f";
                        rightBank = rightBank + "c";
                        if (leftBank.IndexOf("w") != -1 & leftBank.IndexOf("g") != -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("you can't leave together goat and wolf! ");
                            rightBank = rightBank.Replace("f", "");
                            rightBank = rightBank.Replace("c", "");
                            leftBank = leftBank + "f";
                            leftBank = leftBank + "c";
                            Console.ReadLine();
                        }
                        break;
                    case 5:
                        rightBank = rightBank.Replace("f", "");
                        leftBank = leftBank + "f";
                        if (rightBank.IndexOf("c") != -1 & rightBank.IndexOf("g") != -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("you can't leave together goat and cabage! ");
                            leftBank = leftBank.Replace("f", "");
                            rightBank = rightBank + "f";
                            Console.ReadLine();
                        }
                        if (rightBank.IndexOf("w") != -1 & rightBank.IndexOf("g") != -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("you can't leave together goat and wolf! ");
                            leftBank = leftBank.Replace("f", "");
                            rightBank = rightBank + "f";
                            Console.ReadLine();
                        }
                        break;
                    case 6:
                        rightBank = rightBank.Replace("f", "");
                        rightBank = rightBank.Replace("w", "");
                        leftBank = leftBank + "f";
                        leftBank = leftBank + "w";
                        if (rightBank.IndexOf("c") != -1 & rightBank.IndexOf("g") != -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("you can't leave together goat and cabage! ");
                            leftBank = leftBank.Replace("f", "");
                            leftBank = leftBank.Replace("w", "");
                            rightBank = rightBank + "f";
                            rightBank = rightBank + "w";
                            Console.ReadLine();
                        }
                        break;
                    case 7:
                        rightBank = rightBank.Replace("f", "");
                        rightBank = rightBank.Replace("g", "");
                        leftBank = leftBank + "f";
                        leftBank = leftBank + "g";
                        break;
                    case 8:
                        rightBank = rightBank.Replace("f", "");
                        rightBank = rightBank.Replace("c", "");
                        leftBank = leftBank + "f";
                        leftBank = leftBank + "c";
                        if (rightBank.IndexOf("w") != -1 & rightBank.IndexOf("g") != -1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("you can't leave together goat and wolf! ");
                            leftBank = leftBank.Replace("f", "");
                            leftBank = leftBank.Replace("c", "");
                            rightBank = rightBank + "f";
                            rightBank = rightBank + "c";
                            Console.ReadLine();
                        }
                        break;
                    default:
                        Console.WriteLine("Exit");
                        return;
                }
            }
        }
        #endregion

        #region calculator
        static void Calculator()
        {

            int choice;
            float a;
            float b;
            // Set Console.ForegroundColor  value
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine(@"Select the arithmetic operation:
            1. Multiplication 
            2. Divide 
            3. Addition 
            4. Subtraction
            5. Exponentiation 
            6. Exit");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please,  type numbers by step ");

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Please,  type argumrnt 1");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Please,  type argumrnt 2");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Result {a * b}");
                        break;
                    case 2:
                        Console.WriteLine("Please,  type argumrnt 1");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Please,  type argumrnt 2");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Result {a / b}");
                        break;
                    case 3:
                        Console.WriteLine("Please,  type argumrnt 1");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Please,  type argumrnt 2");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Result {a + b}");
                        break;
                    case 4:
                        Console.WriteLine("Please,  type argumrnt 1");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Please,  type argumrnt 2");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Result {a - b}");
                        break;
                    case 5:
                        Console.WriteLine("Please,  type argumrnt 1");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Please,  type argumrnt 2");
                        b = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Result {Math.Pow(a, b)}");
                        break;
                    case 6:
                        return;
                }
                Console.ReadLine();
            }

            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {

            string param = "";
            int fn;
            int res = 1;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine(@"Please input Factorial number or ""Exit"":");
                param = Console.ReadLine();
                if (param.ToUpper() == "EXIT")
                {
                    break;
                }
                int.TryParse(param, out fn);
                res = 1;
                while (fn > 0)
                {
                    res = res * fn;
                    fn--;
                }

                Console.WriteLine($"Result {res}");
                Console.ReadLine();
            }

        }
        #endregion

        #region Gues the number
        static void Gues_the_number()
        {
            const int MyMax = 200;
            Random random = new Random();
            int Guess_number = random.Next(MyMax) + 1;

            string param = "";
            int fn;
            int res = 1;

            Console.Clear();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(@"Enter you guess or ""Exit"":");
                param = Console.ReadLine();
                if (param.ToUpper() == "EXIT")
                {
                    break;
                }
                int.TryParse(param, out fn);
                if (fn < Guess_number)
                {
                    Console.WriteLine($"{fn} - too low");   
                }
                else if (fn == Guess_number)
                {
                    Console.WriteLine($"{fn} - BRAVO!!!");
                    break;
                }
                else
                { 
                    Console.WriteLine($"{fn} - too hight"); 
                }
            }

        }
        #endregion
    }
}
