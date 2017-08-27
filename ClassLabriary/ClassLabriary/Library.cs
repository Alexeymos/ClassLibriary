using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabriary
{
    public class Library
    {
        book[] arrlib = new book[2];
        public Library()
        {
            book book1 = new book() { number = 1, name = "book1", autor = "autor1", usertake = false };
            book book2 = new book() { number = 2, name = "book2", autor = "autor2", usertake = false };
            arrlib[0] = book1;
            arrlib[1] = book2;
        }
        //BOOK LIST
        public void BookList()
        {
            Console.Clear();
            Console.WriteLine("Book List");
            for (int i = 0; i < arrlib.Length; i++)
            {
                if (arrlib[i].usertake != true)
                {
                    Console.WriteLine(arrlib[i].number + " " + arrlib[i].name + " " + arrlib[i].autor + " ");
                }
                else
                {
                    Console.WriteLine(i + 1 + " in use");
                }
            }

        }//TAKE BOOKS
        public void TakeBooks()
        {
            while (true)
            {
                int numberbook = int.Parse(Console.ReadLine());
                if (arrlib[numberbook - 1].name == "empty")
                {
                    Console.WriteLine("This shelf is empty");
                    Console.WriteLine("press any key");
                    Console.ReadLine();
                    break;
                }
                if (arrlib[numberbook - 1].usertake != true)
                {
                    arrlib[numberbook - 1].usertake = true;
                    Console.Clear();
                    BookList();
                    Console.WriteLine("press any key");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("This book is already in use.\n");
                }
                Console.WriteLine("press Enter key");
                Console.ReadLine();
                break;
            }
        }
        //RETURN BOOK
        public void ReturnBooks()
        {
            int numberbook = int.Parse(Console.ReadLine());
            if (arrlib[numberbook - 1].usertake == true)
            {
                arrlib[numberbook - 1].usertake = false;
                Console.Clear();
                BookList();
            }
            else
            {
                Console.WriteLine("This shelf is occupied.\n");
            }
            Console.WriteLine("press Enter key");
            Console.ReadKey();
        }//ADD BOOKS
        public void AddBooks()
        {
            int bookempty = 0;
            while (true)
            {
                for (int k = 0; k < arrlib.Length; k++)
                {
                    if (arrlib[k].name == "empty")
                    {
                        Console.Clear();
                        Console.WriteLine("Enter name new book");
                        arrlib[k].name = Console.ReadLine();
                        Console.WriteLine("Enter Autor new book");
                        arrlib[k].autor = Console.ReadLine();
                        arrlib[k].usertake = false;
                        bookempty = 1;
                        BookList();
                        Console.WriteLine();
                        Console.WriteLine("press any key to Exit");
                        Console.ReadLine();
                        break;
                    }
                    
                }
                if (bookempty == 1)
                {
                    bookempty = 0;
                    break;
                }
                book[] arrlib1 = new book[arrlib.Length + 1];
                for (int i = 0; i < arrlib.Length; i++)
                {
                    arrlib1[i] = arrlib[i];
                }
                arrlib = arrlib1;
                arrlib[arrlib.Length - 1] = new book();
                Console.Clear();
                Console.WriteLine("Enter name new book");
                arrlib[arrlib.Length - 1].name = Console.ReadLine();
                Console.WriteLine("Enter Autor new book");
                arrlib[arrlib.Length - 1].autor = Console.ReadLine();
                arrlib[arrlib.Length - 1].number = arrlib.Length;
                arrlib[arrlib.Length - 1].usertake = false;

                BookList();
                Console.WriteLine();
                Console.WriteLine("press -1- to more Add");
                Console.WriteLine("Other button to Exit");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
        }
        public void DeleteBook()
        {
            while (true)
            {
                Console.Clear();
                BookList();
                Console.WriteLine();
                Console.WriteLine("Delete menu");
                Console.WriteLine("press number book to delete");
                Console.WriteLine("press 0 key to Exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    break;
                }
                else if (choice > arrlib.Length)
                {
                    continue;
                }
                else
                {
                    arrlib[choice - 1].name = "empty";
                    arrlib[choice - 1].autor = " ";
                }
            }
        }

    }
}
