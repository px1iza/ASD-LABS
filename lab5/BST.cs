namespace lab5;

class BST
{
    public Node Root;
    Random rnd = new Random();

    // 🔹 Ротація вправо
    public Node RotateRight(Node y)
    {
        Node x = y.Left;
        Node T2 = x.Right;

        x.Right = y;
        y.Left = T2;

        return x;
    }

    // 🔹 Ротація вліво
    public Node RotateLeft(Node x)
    {
        Node y = x.Right;
        Node T2 = y.Left;

        y.Left = x;
        x.Right = T2;

        return y;
    }

    // 🔹 Вставка в КОРІНЬ (ключ = прізвище)
    public Node InsertRoot(Node root, Student student)
    {
        if (root == null)
            return new Node(student);

        if (string.Compare(student.Surname, root.Data.Surname) < 0)
        {
            root.Left = InsertRoot(root.Left, student);
            root = RotateRight(root);
        }
        if (rnd.Next(2) == 0)
        {
            root = RotateLeft(root);
        }
        else
        {
            root.Right = InsertRoot(root.Right, student);
            root = RotateLeft(root);
        }
        if (rnd.Next(2) == 0)
        {
            root = RotateRight(root);
        }

        return root;
    }

    public Node Search(Node root, string surname)
    {
        if (root == null || root.Data.Surname == surname)
            return root;

        if (string.Compare(surname, root.Data.Surname) < 0)
            return Search(root.Left, surname);

        return Search(root.Right, surname);
    }
    public void PrintLevelOrder()
    {
        if (Root == null)
            return;
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);
        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            current.Data.Print();

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);

        }
    }
}