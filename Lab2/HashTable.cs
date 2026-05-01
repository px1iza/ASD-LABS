class HashTable
{
    private Vector[] table;
    private int size;

    public HashTable(int size)
    {
        this.size = size;
        table = new Vector[size];
    }

    private int Hash(double key)
    {
        double A = 0.618033;

        double x = Math.Abs(key);

        double frac = (x * A) - Math.Floor(x * A);

        return (int)(size * frac);
    }

    public bool Insert(Vector v)
    {
        double key = v.GetAngle();
        int index = Hash(key);

        for (int i = 0; i < size; i++)
        {
            int newIndex = (index + i) % size;

            if (table[newIndex] == null)
            {
                table[newIndex] = v;
                return true;
            }
        }
        return false;
    }

    public void RemoveByLength(double limit)
    {
        for (int i = 0; i < size; i++)
        {
            if (table[i] != null)
            {
                if (table[i].Length() > limit)
                {
                    table[i] = null;
                }
            }
        }
    }

    public void Print()
    {
        Console.WriteLine("\nХеш-таблиця:");

        for (int i = 0; i < size; i++)
        {
            if (table[i] != null)
            {
                Console.WriteLine(
                    $"[{i}] | key={table[i].GetAngle():F4} | value={table[i]} | len={table[i].Length():F2}"
                );
            }
            else
            {
                Console.WriteLine($"[{i}] | empty");
            }
        }
    }
}