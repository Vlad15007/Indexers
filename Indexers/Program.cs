using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Program
    {
        static string[] pupil = {"Сергей", "Иван", "Федя" };
        static void Main(string[] args)
        {
            for (int i = 0; i < pupil.Length; i++)
            {
                Console.WriteLine(pupil[i]);
            }

            Console.ReadKey();
        }
    }
}
