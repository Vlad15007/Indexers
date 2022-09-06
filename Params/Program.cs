using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    public class Chelovek
    {
        public string Name { get; set; }
        private string[] yvlechenia;

        public Chelovek(string name, params string[] yvlechenia)
        {
            Name = name;
            this.yvlechenia = yvlechenia;
        }

        public void ShowYvlechenia()
        {
            foreach(string hobi in yvlechenia)
            {
                Console.WriteLine(hobi);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Chelovek boris = new Chelovek("Человек Борис", "Петь", "Играть на гитаре", "Шантажировать");

            boris.ShowYvlechenia();

            Console.ReadKey();
        }
    }
}
