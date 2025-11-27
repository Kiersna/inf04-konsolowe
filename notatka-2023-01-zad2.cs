public class Notatka
{
    private static int licznik_notatek;
    private int id;
    protected string tytul;
    protected string tresc;

    public Notatka(string _tytul, string _tresc)
    {
        licznik_notatek += 1;
        id = licznik_notatek;
        tytul = _tytul;
        tresc = _tresc;
    }

    public void wyswietlenie()
    {
        Console.WriteLine($"tytul notatki to: {tytul}");
        Console.WriteLine($"tresc: {tresc}");
    }
    public void diagnostyczna()
    {
        Console.WriteLine($"licznik: {licznik_notatek}; id: {id}; tytul: {tytul}; tresc: {tresc}");
    }
}

public class Program
{
    public static void Main()
    {
        Notatka n1 = new Notatka("siemanko", "lalalla");
        Notatka n2 = new Notatka("czesc i czolem", "pozdrowienia do wiezienia");
        n1.wyswietlenie();
        n1.diagnostyczna();
        n2.wyswietlenie();
        n2.diagnostyczna();
    }
}
/*
**********
    klasa: Notatka
    opis: klasa reprezentuje operacje na notatkach, 4 pola, 1 konstruktor, 2 metody 
    pola: licznik_notatek - przechowuje statyczna wartosc informujaca o ilosci utworzonych notatek
        id - przechowuje informacje ktora w kolejnosci byla to utworzona notatka, dzieki temu polu mozemy unikalnie rozpoznac obiekt; 
        tytul - przechowuje tytul notatki
        tresc - przechowuje tresc notatki 
    autor: autor

***********
*/
