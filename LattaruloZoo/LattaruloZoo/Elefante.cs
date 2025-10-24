using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LattaruloZoo
{
    class Elefante : Animale
    {
        public override double CalcolaCiboDiarioKg()
        {
            
            return Peso * 0.05;
        }

        public override double CalcolaCostoGestioneMensile()
        {
            
            return CalcolaCiboDiarioKg() * 30 * 3;
        }

        public override double EmettiVerso()
        {
            Console.WriteLine("PRUUUU!");
            return 0;
        }

        public override double MostraInformazioni()
        {
            Console.WriteLine($"Specie: Elefante");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Età: {Età}");
            Console.WriteLine($"Peso: {Peso} kg");
            Console.WriteLine($"Cibo giornaliero: {CalcolaCiboDiarioKg()} kg");
            Console.WriteLine($"Costo mensile: {CalcolaCostoGestioneMensile()} euro");
            return 0;
        }
    }
}
