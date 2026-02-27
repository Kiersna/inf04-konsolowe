var rand = new Random();
Console.WriteLine("Ile zestawowo przygotowac");
int ile_zestawow = int.Parse(Console.ReadLine());
int[,] zestawy = new int[ile_zestawow, 6];
Dictionary<int, int> wystapienia_liczby = new Dictionary<int, int>();
void wypelnij(int[,] zestawy, Dictionary<int, int> wystapienia_liczby)
{
    for (int i = 0; i < ile_zestawow; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            int liczba_w_zestawie = rand.Next(1, 50);
            zestawy[i, j] = liczba_w_zestawie;
        }
    }
    for(int k = 1; k<50; k++)
    {
        wystapienia_liczby.Add(k, 0);
    }
    for (int k = 1; k < 50; k++)
    {
        for (int i = 0; i < ile_zestawow; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (k == zestawy[i, j])
                {
                    wystapienia_liczby[k] += 1;
                }
            }
        }
    }
}
void wyswietl(int[,] zestawy, Dictionary<int, int> wystapienia_liczby)
{
    Console.WriteLine("Zestawy Wylosowanych liczb");
    for (int i = 0; i < ile_zestawow; i++)
    {
        Console.WriteLine("");
        Console.Write($"Losowanie {i + 1}: ");
        for (int j = 0; j < 6; j++) {
            Console.Write($"{zestawy[i, j]}, ");
        }
    }
    Console.WriteLine("");
    for(int k = 1;k < 50; k++)
    {
        Console.WriteLine($"Wystapienia liczby {k}: {wystapienia_liczby[k]}");
    }

}
wypelnij(zestawy, wystapienia_liczby);
wyswietl(zestawy, wystapienia_liczby);
                