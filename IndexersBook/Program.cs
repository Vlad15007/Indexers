using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("Борьба с милдью", "Чудесный автор");
            Console.WriteLine(myBook[0]);
            Console.WriteLine(myBook[1]);
            Console.WriteLine(myBook[2]);

            Console.WriteLine(myBook["Глава1"]);
            Console.WriteLine(myBook["Глава2"]);
            Console.WriteLine(myBook["Глава3"]);




            Console.ReadKey();
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public string Avtor { get; set; }

        string[] soderjanie;

        public Book(string name, string avtor)
        {
            Name = name;
            Avtor = avtor;
            soderjanie = new string[]
            {
                "Глава1",
                "Глава2",
                "Глава3"
            };
        }

        public string this[int index]
        {
            get
            {
                if(index >= 0 && index < soderjanie.Length)
                {
                    return soderjanie[index];
                }

                return "Нет такой страницы";
            }
        }
        
        
        public int this[string slovo]
        {
            get
            {
                for (int i = 0; i < soderjanie.Length; i++)
                {
                    if (soderjanie[i] == slovo)
                    {
                        return i;
                    }
                }

                return -1;
            }
        }
    }
}
