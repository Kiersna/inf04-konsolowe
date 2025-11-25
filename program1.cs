// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
/*
*******
nazwa funkcji: Euklides
opis funkcji: znalezienie najwiekszego wspolnego dzielnika 
parametry: a - pierwsza liczba ktorej bedziemy szukac wspolnego najwiekszego dzielnika
    b - druga liczba ktorej bedziemy szukac wspolnego najwiekszego dzielnika
    zwracany typ i opis: zwracana jest liczba calkowita ktora jest najwiekszym wspolnym dzielnikiem dwoch liczb podanych w parametrach
    autor: autor
*/


using System;

public class HelloWorld
{
    public static int Euklides(int a, int b){
        while(a != b){
            if(a > b){
                a = a - b;
            }else{
                b = b - a;
            }
        }
            return a;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(Euklides(40, 450));
    }
}
