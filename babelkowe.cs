void babelkowe(int[] tablica)
{
    for (int i = 0; i < tablica.Length-1; i++)
    {
        for(int j = 0; j<tablica.Length-1-i; j++)
        {
            if (tablica[j] > tablica[j+1])
            {
                int temp = tablica[j]; 
                tablica[j] = tablica[j+1];
                tablica[j+1] = temp;
            }
        }
    }
    foreach(int i in tablica)
    {
        Console.Write(i+", ");
    }
}
int[] tablica = new int[100];
Random rnd = new Random();
for(int i = 0; i <100; i++)
{
    tablica[i] = rnd.Next(0, 1000);
}
babelkowe(tablica);