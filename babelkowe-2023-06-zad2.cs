 //sortowanie babelkowe
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var rand = new Random();
        int[] tablica = new int[100];
        for(int j = 0; j < tablica.Length;j++){
            tablica[j] = rand.Next(100);
        }
        for(int k = 0; k<tablica.Length-1;k++){ //porownanie elementu po zmianie i po kolejnej i az 100 zmian bo ostatnia liczba moze przejsc na poczatek
            for(int i = 0; i<tablica.Length-1; i++){ // porownanie elementu
                if(tablica[i]>tablica[i+1]){
                    int temp = tablica[i];
                    tablica[i] = tablica[i+1];
                    tablica[i+1] = temp;
                }
            }
        }
        foreach(var element in tablica){
            Console.Write(element+", ");
        }
    }
}
