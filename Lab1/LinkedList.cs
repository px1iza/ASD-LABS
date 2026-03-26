class LinkedList
{
    private Node head;

    public bool IsEmpty()
    {
        return head == null;
    }

    public void Insert(int value)
    {
        Node newNode = new Node(value);

        if (IsEmpty())
        {
            head = newNode;
            return;
        }

        Node temp = head;

        while (temp.next != null)
        {
            temp = temp.next;
        }

        temp.next = newNode;
    }

    public int Delete()
    {
        if (IsEmpty())
            throw new Exception("Список порожній");

        int value = head.data;
        head = head.next;

        return value;
    }

    public void Print()
    {
        Node temp = head;

        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }

        Console.WriteLine();
    }
}
