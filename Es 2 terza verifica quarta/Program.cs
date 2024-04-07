using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_2_terza_verifica_quarta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo cerchio: ");
            Cerchio cerchio1 = Cerchio.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo cerchio: ");
            Cerchio cerchio2 = Cerchio.Parse(Console.ReadLine());

            Console.WriteLine("La somma dei due cerchi e': {0}", cerchio1 + cerchio2);
            Console.ReadLine();
        }
    }
}
