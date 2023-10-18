using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Danas radimo sa klasom string.";
            //Ispis stringa
            Console.WriteLine(tekst);

            //Izvuči broj znakova u stringu
            Console.WriteLine("\nBroj znakova: " + tekst.Length);

            //Ispis velikim slovima
            Console.WriteLine("\nVelika slova: " + tekst.ToUpper());

            //Ispis malim slovima
            Console.WriteLine("\nMala slova: " + tekst.ToLower());

            //Substring metoda
            Console.WriteLine("\n -- Substring -- ");
            Console.WriteLine(tekst.Substring(0, 5));
            Console.WriteLine(tekst.Substring(13, tekst.Length - 13));

            //Zamjena znakova
            Console.WriteLine("\n -- Zamjena -- ");
            Console.WriteLine(tekst.Replace("Danas", "Sutra"));

            //Razdvajanje stringa u više stringova
            Console.WriteLine("\n -- Razdvajanje --");
            Console.Write("\nfor petlja\n");
            string[] rijeci = tekst.Split(' ');
            for(int i = 0; i < rijeci.Length; i++)
            {

                Console.WriteLine(rijeci[i]);

            }

            Console.Write("\nforeach\n");

            foreach(string rijec in rijeci)
            {

                Console.WriteLine(rijec);

            }

            //Umetanje znakova u string
            Console.WriteLine("\n -- Umetanje --");
            Console.WriteLine(tekst.IndexOf("radimo"));
            Console.WriteLine(tekst.Insert(tekst.IndexOf("radimo"), "intezivno "));



            Console.ReadKey();
        }
    }
}
