using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_first_project_in_c_
{
    internal class Program
    {
        static void menu()
        {
            return;
        }
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
        static void printer()
        {
            return;
        }
        static void inputDeoding()
        {
            return;
        }
        static void argsReverse()
        {
            return;
        }
        static void sorting()
        {
            return;
        }
        static void maximum()
        {
            return;
        }
        static void minimum()
        {
            return;
        }
        static void average()
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
            Console.WriteLine(inputValidation(args));
        }
    }
}
