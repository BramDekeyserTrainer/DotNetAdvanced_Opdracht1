// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information

/*Ik declareer de variabele teller.
 Dit is een integer.*/
int teller = 0;

/*Ik gebruik een while loop.
 Deze while loop blijft lopen zolang de variabele 'teller' kleiner is dan 100.*/
while (teller < 100)
{
    /*Ik gebruik een if statement.
     Wanneer de vermenigvuldiging van teller met 7,
    kleiner is dan 546, breken we uit de if statement.*/
    if ((teller * 7) > 546)
    {
        /*Ik breek uit de controlestructuur.*/
        break;
    }

    /*Als het vorige statement niet het geval is,
     wordt teller geincriment met 1.
    In dit geval wordt het getal ook in de console vertoond.*/
    else
    {
        Console.WriteLine(teller);
        teller++;
    }
}

/*Door Console.ReadLine() te gebruiken,
 sluit de console niet vanzelf.
De gebruiker moet eerst één toets indrukken alvorens deze wordt gesloten.*/
Console.ReadLine();
