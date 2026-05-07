namespace Lab3
{
    class Node
    {
        public Student Data { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }
        public Node(Student data)
        {
            Data = data;
            Right = null;
            Left = null;
        }
    }
}