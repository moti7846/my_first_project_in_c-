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

        static void start(string[] arr)
        {
            args = arr;
        }

        //מדפיס את התפריט + מעבר לבחירה
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

        //בודק אם הקלט בחירה תקינה
        static void choiceMenu()
        {
            int choice = -1;
            while (choice > 0 && choice < 11) ;
            {
                Console.Write("enter yuor choice: ");
                choice = int.Parse(Console.ReadLine());
            }
            menu(choice);
        }
        //בחירה של התפריט
        static void menu(int choice)
        {
            switch (choice)
            {
                case 1:
                    return;
                case 2:
                    printerList(args);
                    break;
                case 3:
                    printerList(argsReverse(args));
                    break;
                case 4:
                    printerList(sorting(args));
                    break;
                case 5:
                    printer(maximum(args));
                    break;
                case 6:
                    printer(minimum(args));
                    break;
                //case 7:
                //    printer(average(args));
                case 8:
                    return;
                case 9:
                    return;
                case 10:
                    return;

            }
        }
        //אימות קלט מהמשתמש
        static bool inputValidation(string[] args)
        {
            int num;
            bool temp = true;
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
            return temp;
        }
        static void selectionValidation()
        {
            return;
        }
        //מדפיס סטרינג
        static void printer(string str)
        {
            Console.WriteLine(str);
        }
        //מדפיס ליסט
        static void printerList(string[] lst)
        {
            foreach (string i in lst)
            {
                Console.WriteLine(i);
            }
        }
        static void inputDeoding()
        {
            return;
        }
        //הופך ליסט לרוורס
        static string[] argsReverse(string[] args)
        {
            string[] temp = new string[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                temp[i] = args[args.Length - 1 - i];
            }

            return temp;
        }
        //ממיין ליסט מהנמוך לגבוה
        static string[] sorting(string[] args)
        {
            Array.Sort(args);
            return args;
        }
        //מחזיר את הערך הכי גבוה בליסט
        static string maximum(string[] args)
        {
            string[] temp = sorting(args);
            return temp[args.Length - 1];
        }
        //מחזיר את הערך הכי נמוך בליסט
        static string minimum(string[] args)
        {
            string[] temp = sorting(args);
            return temp[0];
        }
        static void average(string[] args)
        {
            return;
        }
        static void listLength()
        {
            return;
        }
        static void total()
        {
            return;
        }
        static void exit()
        {
            return;
        }
        static void nul()
        {
            return;
        }



        static void Main(string[] args)
        {
            if (inputValidation(args))
            {
                printMenu();
            }
        }
    }
}
