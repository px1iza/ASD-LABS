using System;

class Node
{
    public int data;   // значення елемента
    public Node next;  // посилання на наступний елемент

    public Node(int value)
    {
        data = value;
        next = null;
    }
}