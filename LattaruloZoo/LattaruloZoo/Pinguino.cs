using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LattaruloZoo
{
    class Pinguino : Animale
    {
        public override double CalcolaCiboDiarioKg()
        {
           
            return Peso * 0.15;
        }

        public override double CalcolaCostoGestioneMensile()
        {
           
            return CalcolaCiboDiarioKg() * 30 * 4;
        }

        public override double EmettiVerso()
        {
            Console.WriteLine("Squawk!");
            return 0;
        }

        public override double MostraInformazioni()
        {
            Console.WriteLine($"Specie: Pinguino");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Età: {Età}");
            Console.WriteLine($"Peso: {Peso} kg");
            Console.WriteLine($"Cibo giornaliero: {CalcolaCiboDiarioKg()} kg");
            Console.WriteLine($"Costo mensile: {CalcolaCostoGestioneMensile()} euro");
            return 0;
        }
    }
}
