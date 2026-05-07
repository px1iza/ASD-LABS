namespace lab5;

class Node
{
    public Student Data;
    public Node Left;
    public Node Right;

    public Node(Student data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}