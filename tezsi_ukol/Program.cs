using System;

Console.WriteLine("AUTOMAT NA LISTKY");
Console.WriteLine("Zádejte prosím svůj věk");
float.TryParse(Console.ReadLine(), out float vek);
if (vek == 0 || vek < 0|| vek > 120)
    {
    Console.WriteLine("bohužel nejsí jíž narozenej nebo zadal sis špatny věk");
    }
    
else if (vek <= 6 && vek >0)
{
    Console.WriteLine("Podle věku je cena jedné vstupenky 0 Kč (věková kategorie: 1-6 let).");
    Console.WriteLine();
    Console.WriteLine("Zadejte počet lístků:");
    int.TryParse(Console.ReadLine(), out int pocet_listku);
    if (pocet_listku == 0)
        Console.WriteLine("špatnej pocet lístku");
    else
    {
        int cena = pocet_listku * 0;
        Console.WriteLine($"k pladbě {cena}");
    }
}
    
else if (vek <= 14 && vek >6)
    {
    Console.WriteLine("Podle věku je cena jedné vstupenky 60 Kč (věková kategorie: 7-14 let).");
    Console.WriteLine();
    Console.WriteLine("Zadejte počet lístků:");
    int.TryParse(Console.ReadLine(), out int pocet_listku);
    if (pocet_listku == 0)
        Console.WriteLine("špatnej pocet lístku");
    else
    {
        int cena = pocet_listku * 60;
        Console.WriteLine($"k platbě {cena}");
    }
}
    
else if (vek <= 18 && vek > 14)
    {
    Console.WriteLine("Podle věku je cena jedné vstupenky 90 Kč (věková kategorie: 14-18 let).");
    Console.WriteLine();
    Console.WriteLine("Zadejte počet lístků:");
    int.TryParse(Console.ReadLine(), out int pocet_listku);
    if (pocet_listku == 0)
        Console.WriteLine("špatnej pocet lístku");
    else
    {
        Console.WriteLine("máš studenskej průkaz (ano/ne)(+/-)?");
        string odpoved = Console.ReadLine();
        if (odpoved == "ne" || odpoved == "-")
        {
            int cena = pocet_listku * 90;
            Console.WriteLine($"k platbě {cena}");
        }
        else if (odpoved == "ano" || odpoved == "+")
        {
            int cena = pocet_listku * 72;
            Console.WriteLine($"k platbě {cena}");
        }
    }
}

else if (vek <= 26 && vek > 18)
{
    Console.WriteLine("Podle věku je cena jedné vstupenky 120 Kč (věková kategorie: 19-64let).");
    Console.WriteLine();
    Console.WriteLine("Zadejte počet lístků:");
    int.TryParse(Console.ReadLine(), out int pocet_listku);
    if (pocet_listku == 0)
        Console.WriteLine("špatnej pocet lístku");
    else
    { 
        Console.WriteLine("máš studenskej průkaz (ano/ne)(+/-)?");
        string odpoved = Console.ReadLine();
        if (odpoved == "ne" || odpoved == "-")
        {
            int cena = pocet_listku * 120;
            Console.WriteLine($"k platbě {cena}");
        }
        else if (odpoved == "ano" || odpoved == "+")
        {
            int cena = pocet_listku * 96;
            Console.WriteLine($"k platbě {cena}");
        }
    }
    
}

else if (vek <= 64 && vek > 26)
    {
    Console.WriteLine("Podle věku je cena jedné vstupenky 120 Kč (věková kategorie: 19-64let).");
    Console.WriteLine();
    Console.WriteLine("Zadejte počet lístků:");
    int.TryParse(Console.ReadLine(), out int pocet_listku);
    if (pocet_listku == 0)
        Console.WriteLine("špatnej pocet lístku");
    else
    {
        int cena = pocet_listku * 120;
        Console.WriteLine($"k platbě {cena}");
    }
}
    
else if (vek > 64)
    {
    Console.WriteLine("Podle věku je cena jedné vstupenky 120 Kč (věková kategorie: 64+ let).");
    Console.WriteLine();
    Console.WriteLine("Zadejte počet lístků:");
    int.TryParse(Console.ReadLine(), out int pocet_listku);
    if (pocet_listku == 0)
        Console.WriteLine("špatnej pocet lístku");
    else
    {
        int cena = pocet_listku * 80;
        Console.WriteLine($"k platbě {cena}");
    }
}  