using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_first_project_in_c_
{
    internal class Program
    {
        static string[] args;
        //מבצע אימות קלט ומגדיר את args
        static void start(string[] arr)
        {
            if (inputValidation(arr))
            {
                args = arr;
            }
            else
            {
                Console.WriteLine("Enter a number with a space between each number.");
                inputDeoding();
            }
        }
        static void printMenu()
        {
            Console.WriteLine("1. Input a Series. (Replace the current series)");
            Console.WriteLine("2. Display the series in the order it was entered.");
            Console.WriteLine("3. Display the series in the reversed order it was entered.");
            Console.WriteLine("4. Display the series in sorted order (from low to high).");
            Console.WriteLine("5. Display the Max value of the series.");
            Console.WriteLine("6. Display the Min value of the series.");
            Console.WriteLine("7. Display the Average of the series.");
            Console.WriteLine("8. Display the Number of elements in the series.");
            Console.WriteLine("9. Display the Sum of the series.");
            Console.WriteLine("10. Exit.");
            choiceMenu();
        }

        static void choiceMenu()
        {
            int choice;
            string temp;
            do
            {
                Console.Write("enter yuor choice: ");
                temp = Console.ReadLine();
                if (int.TryParse(temp, out choice))
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("choice not good...");
                }

            }
            while (choice < 1 || choice > 10);

            menu(choice);
        }
        static void menu(int choice)
        {
            switch (choice)
            {
                case 1:
                    inputDeoding();
                    break;
                case 2:
                    printerList(args);
                    break;
                case 3:
                    printerList(argsReverse(args));
                    break;
                case 4:
                    printerListInt(sorting(args));
                    break;
                case 5:
                    Console.WriteLine(maximum(args));
                    break;
                case 6:
                    Console.WriteLine(minimum(args));
                    break;
                case 7:
                    Console.WriteLine(average(args));
                    break;
                case 8:
                    Console.WriteLine(listLength(args));
                    break;
                case 9:
                    Console.WriteLine(total(args));
                    break;
                case 10:
                    exit();
                    return;

            }
            printMenu();
        }
        static bool inputValidation(string[] args)
        {
            int num;
            bool temp = true;
            if(listLength(args) <= 2)
            {
                temp = false;
            }
            else
            {
                foreach (string i in args)
                {
                    if (int.TryParse(i, out num))
                    {
                        if (num < 0)
                        {
                            temp = false;
                        }
                    }
                    else
                    {
                        temp = false;
                    }
                }
            }
            return temp;
        }
        


        static void printerListInt(int[] args)
        {
            foreach (int i in args)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void printerList(string[] args)
        {
            foreach (string i in args)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void inputDeoding()
        {
            Console.WriteLine("enter 3 numbers: ");
            string[] temp = Console.ReadLine().Split(' ');
            start(temp);
        }
        static string[] argsReverse(string[] args)
        {
            string[] temp = new string[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                temp[i] = args[args.Length - 1 - i];
            }

            return temp;
        }
        static int[] sorting(string[] args)
        {
            int[] temp = new int[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                temp[i] = Convert.ToInt32(args[i]);
            }
            Array.Sort(temp);
            return temp;
        }
        static int maximum(string[] args)
        {
            int[] temp = sorting(args);
            return temp[args.Length - 1];
        }
        static int minimum(String[] args)
        {
            int[] temp = sorting(args);
            return temp[0];
        }
        static float average(string[] args)
        {
            float sum = 0;
            int[] temp = sorting(args);
            foreach (int i in temp)
            {
                sum += i;
            }
            return sum / listLength(args);
        }
        static int listLength(string[] args)
        {
            return args.Length;
        }
        static float total(string[] args)
        {
            float sum = 0;
            int[] temp = sorting(args);
            foreach (int i in temp)
            {
                sum += i;
            }
            return sum;
        }
        static void exit()
        {
            Console.WriteLine("good day!");
            return;
        }



        static void Main(string[] args)
        {
            start(args);
            if (inputValidation(args))
            {
                printMenu();
            }
        }
    }
}
