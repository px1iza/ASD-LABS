using System;

public class Program
{
    public static void Main(string[] args)
    {
        Queue q = new Queue(5);

        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);
        q.Enqueue(40);
        Console.WriteLine("Черга після вставки:");
        q.Print();

        q.Dequeue();
        q.Dequeue();
        Console.WriteLine("Черга після видалення:");
        q.Print();

        //2завдання
        LinkedList list = new LinkedList();

        list.Insert(10);
        list.Insert(20);
        list.Insert(30);
        list.Insert(40);
        Console.WriteLine("Список після вставки:");
        list.Print();

        list.Delete();
        list.Delete();
        Console.WriteLine("Список після видалення:");
        list.Print();


        //3завдання
        LinkedList list2 = new LinkedList();
        Queue queue2 = new Queue(10); // створюємо чергу 

        list2.Insert(-5);
        list2.Insert(3);
        list2.Insert(7);
        list2.Insert(-2);
        list2.Insert(4);
        Console.WriteLine("Список 2 після вставки:");
        list2.Print();

        int prev = 0;

        while (!list2.isEmpty())
        {
            int value = list2.Delete();
            if (value > 0)
            {
                prev += value;      // сума попереднього + поточного
                queue2.Enqueue(prev);
            }
        }
        Console.WriteLine("Список 2 після видалення додатніх елементів:");
        list2.Print(); // залишилися лише від’ємні (якщо потрібно)

        Console.WriteLine("Черга після переносу додатніх елементів:");
        queue2.Print();


    }
}