using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moshniesiski
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;



            while (true)
            {
                Console.WriteLine(data);
                Console.WriteLine("Что сегодня будешь делать?");
                int pos = 2;
                ConsoleKeyInfo key;

                do
                {
                    if (data.Date == new DateTime(2023, 10, 17))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                        Console.WriteLine("Что сегодня будешь делать?");
                        Console.WriteLine("   1.Помыться");
                        Console.WriteLine("   2.покушать");
                        Console.WriteLine("   3.поиграть в дотку");
                        Console.WriteLine("   4.Культурно выпить");
                    }
                    if (data.Date == new DateTime(2023, 10, 20))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                        Console.WriteLine("Что сегодня будешь делать?");
                        Console.WriteLine("   1.Пойти в шарагу");
                        Console.WriteLine("   2.Поесть воду");
                        Console.WriteLine("   3.Поспать");
                        Console.WriteLine("   4.Пыхнуть");
                    }

                    if (data.Date == new DateTime(2023, 10, 22))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                        Console.WriteLine("Что сегодня будешь делать?");
                        Console.WriteLine("   1.Катнуть в мфц за паспортом");
                        Console.WriteLine("   2.Съездить в диспансер");
                       
                    }

                    if (data.Date != new DateTime(2023, 10, 20) && data.Date != new DateTime(2023, 10, 17) && data.Date != new DateTime(2023, 10, 22))
                    {
                        Console.Clear();
                        Console.WriteLine(data);
                    }
                    


                   
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    key = Console.ReadKey();
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("  ");


                    if (key.Key == ConsoleKey.UpArrow && pos != 2)
                    {
                        pos--;
                    }
                    if (key.Key == ConsoleKey.DownArrow && pos != 5)
                    {
                        pos++;
                    }


                        Console.SetCursorPosition(0, 0);

                    if (key.Key == ConsoleKey.RightArrow)
                    {

                        data = data.AddDays(1);
                        Console.WriteLine(data);

                    }
                    if (key.Key == ConsoleKey.LeftArrow)
                    {
                        data = data.AddDays(-1);
                        Console.WriteLine(data);
                    }


                } while (key.Key != ConsoleKey.Enter);

                
                
                if (pos == 2 && data.Date == new DateTime(2023, 10, 17))
                {
                    Console.Clear();
                    Notes pomitsa = new Notes();
                    Console.WriteLine("Помыться");
                    Console.WriteLine("");
                    pomitsa.name = "Описание: мыться чтоб не вонять как тварь";
                    DateTime vremya = DateTime.Now;
                    Console.WriteLine(pomitsa.name);
                    Console.WriteLine("Дата: " + vremya);
                }



                if (pos == 2 && data.Date == new DateTime(2023, 10, 20))
                {
                    Console.Clear();
                    Notes sharaga = new Notes();
                    Console.WriteLine("Пойти в шарагу");
                    Console.WriteLine(" ");
                    sharaga.name = "Описание: невыспаться и в тильте сидеть несколько пар";
                    DateTime vremya = DateTime.Now;
                    Console.WriteLine(sharaga.name);
                    Console.WriteLine("Дата: " + vremya);
                }

                if (pos == 2 && data.Date == new DateTime(2023, 10, 22))
                {
                    Console.Clear();
                    Notes sharaga = new Notes();
                    Console.WriteLine(" 1.Паспорт");
                    Console.WriteLine(" ");
                    sharaga.name = "Описание: катнуть в мфц за паспортом";
                    DateTime vremya = DateTime.Now;
                    Console.WriteLine(sharaga.name);
                    Console.WriteLine("Дата: " + vremya);
                }


                if (pos == 3 && data.Date == new DateTime(2023, 10, 17))
                {
                    Console.Clear();
                    Notes pohavat = new Notes();
                    Console.WriteLine("Похавать");
                    Console.WriteLine("");
                    pohavat.name = "похавать в маке на всю степуху";
                    DateTime vremya = DateTime.Now;
                    Console.WriteLine(pohavat.name);
                    Console.WriteLine("Дата: " + vremya);
                }
                if (pos == 3 && data.Date == new DateTime(2023, 10, 20))
                {
                    Console.Clear();
                    Notes pomitsa = new Notes();
                    Console.WriteLine("Поесть воду");
                    Console.WriteLine("");
                    pomitsa.name = "Описание: поесть воду т.к. степуха не пришла";
                    DateTime vremya = DateTime.Now;
                    Console.WriteLine(pomitsa.name);
                    Console.WriteLine("Дата: " + vremya);
                }

                if (pos == 3 && data.Date == new DateTime(2023, 10, 22))
                {
                    Console.Clear();
                    Notes pomitsa = new Notes();
                    Console.WriteLine("Диспансер");
                    Console.WriteLine("");
                    pomitsa.name = "Описание: съездить в диспансер чтобы пройти обследрование";
                    DateTime vremya = DateTime.Now;
                    Console.WriteLine(pomitsa.name);
                    Console.WriteLine("Дата: " + vremya);
                }

                if (pos == 4 && data.Date == new DateTime(2023, 10, 17))
                {
                    Console.Clear();
                    Notes pomitsa = new Notes();
                    Console.WriteLine("Поиграть в дотку");
                    Console.WriteLine("");
                    pomitsa.name = "Описание: сидеть в тильте потому что раки в команде";
                    DateTime vremya = DateTime.Now;
                    Console.WriteLine(pomitsa.name);
                    Console.WriteLine("Дата: " + vremya);
                }
                if (pos == 4 && data.Date == new DateTime(2023, 10, 20))
                {
                    Console.Clear();
                    Notes pomitsa = new Notes();
                    Console.WriteLine("Поспать");
                    Console.WriteLine("");
                    pomitsa.name = "Описание: либо выходной, либо ты проспал пары :)";
                    DateTime vremya = DateTime.Now;
                    Console.WriteLine(pomitsa.name);
                    Console.WriteLine("Дата: " + vremya);
                }
                if (pos == 5 && data.Date == new DateTime(2023, 10, 17))
                {
                    Console.Clear();
                    Notes pomitsa = new Notes();
                    Console.WriteLine("Культурно выпить ");
                    Console.WriteLine("");
                    pomitsa.name = "Описание: собраться со своими любимыми друзьяшками и культурно посидеть";
                    DateTime vremya = DateTime.Now;
                    Console.WriteLine(pomitsa.name);
                    Console.WriteLine("Дата: " + vremya);
                }
                if (pos == 5 && data.Date == new DateTime(2023, 10, 20))
                {
                    Console.Clear();
                    Notes pomitsa = new Notes();
                    Console.WriteLine("Пыхнуть");
                    Console.WriteLine("");
                    pomitsa.name = "Описание: дать по тяге";
                    DateTime vremya = DateTime.Now;
                    Console.WriteLine(pomitsa.name);
                    Console.WriteLine("Дата: " + vremya);
                }

                Console.ReadKey();
                Console.Clear();


            }
        }
       
    }
}