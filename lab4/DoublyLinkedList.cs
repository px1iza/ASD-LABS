namespace Lab4
{
    class DoublyLinkedList
    {
        private Node head;
        private Node tail;

        public void Add(Student student)
        {
            Node newNode = new Node(student);

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;

                newNode.Prev = tail;

                tail = newNode;
            }
        }
        public void SelectionSortBySurname()
        {
            Node current = head;
            while (current != null)
            {
                Node minNode = current;
                Node nextNode = current.Next;
                while (nextNode != null)
                {
                    if (string.Compare(nextNode.Data.Surname, minNode.Data.Surname) < 0)
                    {
                        minNode = nextNode;
                    }
                    nextNode = nextNode.Next;
                }
                // міняємо місцями тільки дані (Student)
                if (minNode != current)
                {
                    Student temp = current.Data;

                    current.Data = minNode.Data;

                    minNode.Data = temp;
                }
                current = current.Next;
            }

        }
        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine($"{current.Data.Surname} {current.Data.Name} - {current.Data.Form}");
                current = current.Next;
            }
        }
    }
}