// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        operacje o1 = new operacje(1000);
        o1.wyswietlanie();
        o1.wyswietl_nieparzyste();
        Console.WriteLine("Znaleziony index to: "+o1.znajdz(100));
        Console.WriteLine("Srednia wszytskich liczb to: " + o1.srednia());
        
    }
}
public class operacje{
    private int ilosc_elementow_tablicy;
    private int[] tablica;
    Random rnd = new Random();
    public operacje(int ilosc){
        ilosc_elementow_tablicy = ilosc;
        tablica = new int[ilosc_elementow_tablicy];
        for(int i = 0; i < ilosc_elementow_tablicy; i++){
            tablica[i] = rnd.Next(1, 1000);
        }
    }
    public void wyswietlanie(){
        for(int i = 0; i<tablica.Length; i++){
            Console.WriteLine(i+": "+tablica[i]);
        }
    }
    public int znajdz(int szukana){
        for(int i = 0; i<tablica.Length; i++){
            if(szukana == tablica[i]){
                return i;
            }
        }
        return -1;
    }
    public int srednia(){
        int suma = 0;
        for(int i = 0; i<tablica.Length; i++){
                suma += tablica[i];
            }
        return suma/tablica.Length;
    }
    public void wyswietl_nieparzyste(){
        int ilosc = 0;
        for(int i = 0; i<tablica.Length; i++){
            if(tablica[i] % 2 == 0){
                Console.WriteLine(tablica[i]);
                ilosc++;
            }
        }
        Console.WriteLine("ilosc nieparzystych: "+ ilosc);
    }
}
