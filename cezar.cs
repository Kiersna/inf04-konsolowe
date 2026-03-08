// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine(cezar("pozdrowienia", 1));
    }
    private static string cezar(string slowo, int klucz){
        string alfabet = "abcdefghijklmnoprstuvxyz";
        string nowe_slowo = "";
        foreach(char litera in slowo){
            int index = (alfabet.IndexOf(litera) + klucz) % alfabet.Length;
            nowe_slowo += alfabet[index];
        }
        return nowe_slowo;
    }
}
