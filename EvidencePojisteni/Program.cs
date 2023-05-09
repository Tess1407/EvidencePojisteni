using EvidencePojisteni;

Console.WriteLine("--------------------");
Console.WriteLine("Evidence pojištění");
Console.WriteLine("--------------------");
Pojistovna pojistovna = new Pojistovna();

bool konec = false;
while (!konec)
{
    Console.WriteLine("Vyberte si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Zobrazit seznam pojištěných");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");
    string volba = Console.ReadLine();
    switch (volba)
    {
        case "1":
            pojistovna.VytvoritPojistence();
            break;
        case "2":
            Console.WriteLine("Seznam pojištěných: ");
            pojistovna.ZobrazitSeznamPojistencu();
            break;
        case "3":
            pojistovna.VyhledatPojistence();
            break;
        case "4":
            konec = true;
            break;
        default:
            Console.WriteLine("Neplatná volba, opakujte akci.");
            break;
    }
}
