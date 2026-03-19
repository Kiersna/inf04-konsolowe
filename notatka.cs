/*
klasa: Notatka
opis: klasa reprezentuje notatke i informacja o niej
pola: liczba_notatek - przechowuje liczbe stworzonych notatek
    id - przechowuje unikalna wartosc po ktorej mozna rozrozniac te same notatki 
    tytul - przechowuje tytul notatki
    tresc - przechowuje tresc notatki

autor: <numer zdającego>
*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Notatka n1 = new Notatka("Fajna notateczka", "chcialbym powiedziec o fajnej notatce");
        n1.wyswietlanie();
        n1.diagnostyczna();
    }
}
public class Notatka{
    private static int liczba_notatek = 0;
    private int id;
    protected string tytul;
    protected string tresc;
    public Notatka(string _tytul, string _tresc){
        liczba_notatek++;
        id = liczba_notatek;
        tytul = _tytul;
        tresc = _tresc;
    }
    public void wyswietlanie(){
        Console.WriteLine("Tytul: "+tytul);
        Console.WriteLine("Tresc: "+tresc);
    }
    public void diagnostyczna(){
        Console.WriteLine($"liczba notatek: {liczba_notatek}, id: {id}, tytul: {tytul}, tresc: {tresc}");
    }
}
