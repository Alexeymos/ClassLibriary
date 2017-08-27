using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabriary
{
    class Program
    {

        static void Main(string[] args)
        {
            Library librclas = new Library();
            users usersclas = new users();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("welcome to Library");
                Console.WriteLine("Main menu");
                Console.WriteLine("1-Log in");
                Console.WriteLine("2-Registration");
                Console.WriteLine("3-Exit");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    usersclas.LogPass(librclas);
                }
                else if(choice=="2")
                {
                    usersclas.RegUser(librclas);
                }
                else if(choice=="3")
                {
                    break;
                }
            }
        }
    }
}
