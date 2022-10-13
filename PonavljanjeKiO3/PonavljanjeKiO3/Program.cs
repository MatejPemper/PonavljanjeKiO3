using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeKiO3
{
    internal class Program
    {

        class Vozilo
        {
            private bool JeLiLeti, JeLiPlovi;

            public bool JeLiLeti1 { get => JeLiLeti; set => JeLiLeti = value; }
            public bool JeLiPlovi1 { get => JeLiPlovi; set => JeLiPlovi = value; }

            public string KudaVozi()
            {
                return ("U zraku: " + JeLiLeti + " Na moru: " + JeLiPlovi);
            }

        }
        class Brod : Vozilo
        {
            public Brod()
            {
                JeLiLeti1 = false;
                JeLiPlovi1 = true;
            }
        }
        class Zrakoplov : Vozilo
        {

            public Zrakoplov()
            {
                JeLiLeti1 = true;
                JeLiPlovi1 = false;
            }
        }


        static void Main(string[] args)
        {

            Brod brod = new Brod();
            Zrakoplov z = new Zrakoplov();

            Console.WriteLine("Brod: " + brod.KudaVozi());
            Console.WriteLine("Zrakoplov: " + z.KudaVozi());



            Console.ReadKey();

        }
    }
}
