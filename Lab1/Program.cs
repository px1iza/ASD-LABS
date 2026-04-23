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


        LinkedList mylist2 = new LinkedList();
        Queue myqueue2 = new Queue(10);

        mylist2.Insert(-5);
        mylist2.Insert(3);
        mylist2.Insert(7);
        mylist2.Insert(-2);
        mylist2.Insert(4);
        Console.WriteLine("Список 2 після вставки:");
        mylist2.Print();

        int total = 0;
        LinkedList tempList = new LinkedList();

        while (!mylist2.IsEmpty())
        {
            int current = mylist2.Delete();

            if (current > 0)
            {
                total += current;
                myqueue2.Enqueue(total);
            }
            else
            {
                tempList.Insert(current);
            }
        }
        mylist2 = tempList;

        Console.WriteLine("Черга після переносу додатніх елементів:");
        myqueue2.Print();

        Console.WriteLine("Список після переносу додатніх елементів:");
        mylist2.Print();

    }
}