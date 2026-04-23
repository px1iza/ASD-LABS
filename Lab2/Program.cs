class Program
{
    static void Main()
    {
        Console.Write("Введіть розмір хеш-таблиці: ");
        int size = int.Parse(Console.ReadLine()!);

        HashTable hashTable = new HashTable(size);
        Random rand = new Random();

        int count = 0;

        while (count < size)
        {
            double x = rand.NextDouble() * 20 - 10;
            double y = rand.NextDouble() * 20 - 10;

            if (x == 0 && y == 0)
                continue;

            Vector v = new Vector(x, y);

            if (hashTable.Insert(v))
            {
                count++;
            }
        }

        hashTable.Print();

        Console.WriteLine("\nВведіть межу довжини для видалення:");
        double limit = double.Parse(Console.ReadLine()!);

        hashTable.RemoveByLength(limit);
        hashTable.Print();
    }
}