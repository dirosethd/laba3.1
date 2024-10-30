try
{
        for (int i = 1; i <= 1000; i++)
            if (HasDuplicates(i)) Console.WriteLine(i);

    static bool HasDuplicates(int n)
    {
        bool[] seen = new bool[10];
        foreach (char d in n.ToString())
            if (seen[d - '0']) return true;
            else seen[d - '0'] = true;
        return false;
    }

}
catch
{

}