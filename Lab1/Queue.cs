using System;

public class Queue
{
    private int[] arr;
    private int count;
    private int head;
    private int tail;

    public Queue(int size)
    {
        arr = new int[size];
        count = 0;
        head = 0;
        tail = -1;
    }

    public bool isFull()
    {
        return count == arr.Length;
    }

    public bool isEmpty()
    {
        return count == 0;
    }

    public bool Enqueue(int value)
    {
        if (isFull())
            return false;

        tail++;
        arr[tail] = value;
        count++;
        return true;
    }

    public int Dequeue()
    {
        if (isEmpty())
            throw new Exception("Черга порожня");

        int removed = arr[head];

        for (int i = head + 1; i <= tail; i++)
        {
            arr[i - 1] = arr[i];
        }
        tail--;
        count--;

        return removed;
    }
    public void Print()
    {
        for (int i = head; i <= tail; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    public int Last()
    {
        return isEmpty() ? 0 : arr[tail];
    }

}
