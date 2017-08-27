using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabriary
{
    class users
    {
        User[] arrusers;
        public users()
        {
            arrusers = new User[2];
            User user1 = new User() { name = "a", pass = "1", isadmin = true, booktake = 0 };
            User user2 = new User() { name = "u", pass = "2", isadmin = false, booktake = 0 };
            arrusers[0] = user1;
            arrusers[1] = user2;
        }
        public void LogPass(Library librclas)
        {
            bool tomenu = false;
            while (true)
            {
                if (tomenu == true)
                {
                    tomenu = false;
                    break;
                }
                Console.Clear();
                Console.WriteLine("Enter Login");
                string login = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine();
                for (int i = 0; i < arrusers.Length; i++)
                {
                    if (login == arrusers[i].name)
                    {

                        if (pass == arrusers[i].pass)
                        {
                            if (arrusers[i].isadmin == true)
                            {
                                AdminMenu(librclas, ref tomenu, i);
                                //admin menu
                            }
                            else
                            {
                                UserMenu(librclas, ref tomenu, i);
                                //user menu
                            }
                        }
                        else
                        {
                            Console.WriteLine("incorrect password.\npress any key");
                            Console.ReadKey();
                            break;
                        }
                    }
                    else if (i < arrusers.Length)
                    {
                        continue;
                    }

                }

            }
        }//USER MENU
        public void UserMenu(Library librclas, ref bool tomenu, int i)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("USER MENU");
                Console.WriteLine("1-take book");
                Console.WriteLine("2-return book");
                Console.WriteLine("3-list books");
                Console.WriteLine("4-Exit to Main menu");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    TakeBook(librclas, i);
                }
                else if (choice == "2")
                {
                    ReturnBook(librclas, i);
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    librclas.BookList();
                    Console.WriteLine("Press Enter key");
                    Console.ReadLine();
                }
                else if (choice == "4")
                {
                    tomenu = true;
                    break;
                }
            }

        }//TAKE BOOK 
        public void TakeBook(Library librclas, int i)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Take Menu.\n");
                librclas.BookList();//to Library BookList
                Console.WriteLine();
                Console.WriteLine("Enter number book to take");
                librclas.TakeBooks();//to Library TakeBooks
                Console.ReadLine();
                break;
            }
        }//RETURN BOOK
        public void ReturnBook(Library librclas, int i)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Return Menu.\n");
                librclas.BookList();
                Console.WriteLine();
                Console.WriteLine("Enter number book to return");
                librclas.ReturnBooks();
                Console.ReadLine();
                break;
            }
        }//ADMIN MENU
        public void AdminMenu(Library librclas, ref bool tomenu, int i)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ADMIN MENU");
                Console.WriteLine("1-List Book");
                Console.WriteLine("2-List Users");
                Console.WriteLine("3-Add Book");
                Console.WriteLine("4-Delete Book");
                Console.WriteLine("5-Exit to Main menu.\n");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    //list book
                    Console.Clear();
                    librclas.BookList();
                    Console.WriteLine("Press Enter key");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    //list users
                    UsersList();
                }
                else if (choice == "3")
                {
                    //add book
                    librclas.AddBooks();
                }
                else if (choice == "4")
                {
                    //delete book
                    librclas.DeleteBook();
                }
                else if (choice == "5")
                {
                    //exit main menu
                    tomenu = true;
                    break;
                }

            }
        }
        //USERS LIST
        public void UsersList()
        {
            Console.Clear();
            Console.WriteLine("User List");
            for (int i = 0; i < arrusers.Length; i++)
            {
                if (arrusers[i].isadmin == true)
                {
                    Console.WriteLine(arrusers[i].name + " " + "Admin");
                }
                else
                {
                    Console.WriteLine(arrusers[i].name + " " + " User");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press Enter key");
            Console.ReadLine();
        }
        public void RegUser(Library librclas)
        {
           while(true)
            {
                User[] arrusers1 = new User[arrusers.Length + 1];
                for (int i = 0; i < arrusers.Length; i++)
                {
                   arrusers1[i] = arrusers[i];
                }
                arrusers = arrusers1;
                arrusers[arrusers.Length - 1] = new User();
                Console.Clear();
                Console.WriteLine("Enter name ");
                arrusers[arrusers.Length - 1].name = Console.ReadLine();
                Console.WriteLine("Enter Password ");
                arrusers[arrusers.Length - 1].pass = Console.ReadLine();
                arrusers[arrusers.Length - 1].isadmin = false;
                arrusers[arrusers.Length - 1].booktake = 0;
                Console.WriteLine("press any key to main menu");
                break;
            }
        }
    }
}
