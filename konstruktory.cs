// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Osoba o1 = new Osoba(1, "Marek");
        o1.wypisz("Arek");
        Osoba o2 = new Osoba();
        o2.wypisz("Pozdro");
    }
}

public class Osoba{
    private int id;
    private string imie;
    public static int liczba_instancji = 0;
    
    public Osoba(){
        id = 0;
        imie = "";
        liczba_instancji += 1;
    }
    public Osoba(int _id, string _imie){
        id = _id;
        imie = _imie;
        liczba_instancji += 1;
    }
    public Osoba(Osoba o1){
        id = o1.id;
        imie = o1.imie;
        liczba_instancji += 1;
    }
    public void wypisz(string _imie){
        if(imie == ""){
            Console.WriteLine("brak danych");
        }
        else{
        Console.WriteLine($"Cześć {_imie}, mam na imię {imie}");
        }
        
    }
}
