public class Program
{

    public static void wypelnienie(bool[] bools)
    {

        for (int i = 2; i < bools.Length; i++)
        {
            bools[i] = true;
        }
    }
    public static void erastotes(bool[] bools)
    {
        List<int> indeksy = new List<int>();
        for(int i = 2; i*i<bools.Length; i++)
        {
            if (bools[i] == true)
            {
                for(int j = 2*i; j<bools.Length; j+=i)
                {
                    bools[j] = false;
                }
            }
        }
        for(int i = 0; i<bools.Length; i++)
        {
            if (bools[i] == true)
            {
                indeksy.Add(i);
            }
        }
        foreach(var element in indeksy)
        {
            Console.Write(element + ", ");
        }
    }
    public static void Main()
    {

        bool[] bools = new bool[100];
        wypelnienie(bools);
        erastotes(bools);
    }
}
