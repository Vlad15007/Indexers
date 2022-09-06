using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeathNote tetradRuka = new DeathNote(20);

            tetradRuka[0] = "Человек Борис";
            tetradRuka[0] = "Человек Карниз";
            tetradRuka["Карниз"] = "Не Человек Карниз";

            Console.WriteLine(tetradRuka[0]);

            Console.ReadLine();
        }
    }

    public class DeathNote
    {
        string[] zapisi;
        public DeathNote(int size)
        {
            zapisi = new string[size];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < zapisi.Length)
                {
                    return zapisi[index];
                }

                return "Нет такой страницы";
            }
            set
            {
                if (index >= 0 && index < zapisi.Length)
                {
                    zapisi[index] += value + ", ";
                }
            }
        }


        public string this[string slovo]
        {
            get
            {
                for (int i = 0; i < zapisi.Length; i++)
                {
                    if (zapisi[i].IndexOf(slovo) != -1)
                    {
                        return "Совпадение на странице : " + i;
                    }
                }

                return "Отсутствует запись";
            }
            set
            {
                for (int i = 0; i < zapisi.Length; i++)
                {
                    if (zapisi[i].IndexOf(slovo) != -1)
                    {
                        zapisi[i] += value + ", ";
                        return;
                    }
                }

                Console.WriteLine("Нет такой записи");
            }
        }
    }
}
