using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    internal class Pojistovna
    {
        private List<Pojistenec> seznamPojistencu = new List<Pojistenec>();
        public void VytvoritPojistence()
        {
            Console.WriteLine("Zadejte jméno: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte věk: ");
            int vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte telefonní číslo: ");
            string telefon = Console.ReadLine();

            Pojistenec novyPojistenec = new Pojistenec(jmeno, prijmeni, vek, telefon);
            Console.WriteLine("Data byla uložena. Pokračujte");
            seznamPojistencu.Add(novyPojistenec);
        }
        public void ZobrazitSeznamPojistencu()
        {
            foreach (Pojistenec pojistenec in seznamPojistencu)
            {
                Console.WriteLine($"{pojistenec.Jmeno} {pojistenec.Prijmeni} ({pojistenec.Vek}), tel: {pojistenec.Telefon}");
            }
        }
        public void VyhledatPojistence()
        {
            Console.Write("Zadejte jméno nebo příjmení pojištěnce: ");
            string hledanyVyraz = Console.ReadLine();
            bool nalezeno = false;
            foreach (Pojistenec pojistenec in seznamPojistencu)
            {
                if (pojistenec.Jmeno.Contains(hledanyVyraz) || pojistenec.Prijmeni.Contains(hledanyVyraz))
                {
                    Console.WriteLine($"{pojistenec.Jmeno} {pojistenec.Prijmeni} ({pojistenec.Vek}), tel: {pojistenec.Telefon}");
                    nalezeno = true;
                }
            }
            if (!nalezeno)
            { Console.WriteLine("Pojištěnec nenalezen"); }
        }
    }
}
