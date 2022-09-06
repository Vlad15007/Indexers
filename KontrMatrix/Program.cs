using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrMatrix
{
    public interface ITovar
    {
        int Stoimost { get; set; }
        int Buy(int money);
    }

    public class Ponchiki : ITovar
    {
        public int Stoimost { get; set; } = 40;

        public int Buy(int money)
        {
            if(money < Stoimost)
            {
                Console.WriteLine("Нехватает средств");
                return money;
            }
            return money - Stoimost;
        }

        public void LipnytKRykam()
        {
            Console.WriteLine("пальчики оближешь");
        }
    }

    public class PonchikiVGlazyri : Ponchiki
    {
        public PonchikiVGlazyri()
        {
            Stoimost = 60;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            Ponchiki myPonchik = new Ponchiki();
            ITovar myTovar = myPonchik;

            Ponchiki[] magazin = { new Ponchiki(), new Ponchiki(), new PonchikiVGlazyri(), new Ponchiki() };

            for (int i = 0; i < magazin.Length; i++)
            {
                magazin[i].Buy(100);
                magazin[i].LipnytKRykam();
            }

            Console.WriteLine(new string('-', 30));

            ITovar[] tovaru = magazin;
            for (int i = 0; i < tovaru.Length; i++)
            {
                tovaru[i].Buy(100);
                //tovaru[i].LipnytKRykam();
            }

            Console.WriteLine(new string('-', 30));

            Ponchiki[] newmagazin = (Ponchiki[])tovaru;
            for (int i = 0; i < newmagazin.Length; i++)
            {
                newmagazin[i].Buy(100);
                newmagazin[i].LipnytKRykam();
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(new string('-', 30));

            //short myShort = 10;
            //int myInt = myShort;

            //short[] massivShort = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] massivInt = massivShort;

            Console.ReadKey();
        }
    }
}
