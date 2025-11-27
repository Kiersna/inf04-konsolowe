public class Program
{
    //public static int[] _pesel = [5, 5, 0, 3, 0, 1, 0, 1, 1, 9, 3];
    public static bool sprawdz_pesel(List<int> pesel)
    {
        int suma = 0;
        /*int licznik = 1;
        foreach(int i in pesel)
        {
            if(licznik <= 4)
            {
                if
            }
            else { licznik = 0; }
        }   */
        suma += pesel[0];
        suma += pesel[1]*3;
        suma += pesel[2]*7;
        suma += pesel[3]*9;
        suma += pesel[4];
        suma += pesel[5]*3;
        suma += pesel[6]*7;
        suma += pesel[7]*9;
        suma += pesel[8];
        suma += pesel[9]*3;
        int m = suma % 10;
        if (m == 0)
        {
            int r = 0;
            if (pesel[10] == r)
            {
                return true;
            }
            else { return false; }
        }
        else 
        { 
            int r = 10 - m;
            if (pesel[10] == r)
            {
                return true;
            }
            else { return false; }
        }
        
    }
    public static char sprawdz_plec(List<int> pesel) 
    {
        if (pesel[9] % 2 == 0)
        {
            return 'K';
        }
        else
        {
            return 'M';
        }
    }

    public static void Main()
    {
        List<int> pesel2_tab = [];
        Console.WriteLine("Podaj pesel: ");
        string pesel2 = Console.ReadLine();
        foreach(int cyfra in pesel2)
        {
            pesel2_tab.Add(cyfra);
        }
        if (sprawdz_plec(pesel2_tab) == 'K'){
            Console.WriteLine("Kobieta");
        }
        else { Console.WriteLine("Mężczyzna"); }

        if (sprawdz_pesel(pesel2_tab))
        {
            Console.WriteLine("poprawny pesel");
        }
        else
        {
            Console.WriteLine("niepoprawny pesel");
        }
    }
}
