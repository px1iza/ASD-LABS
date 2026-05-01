namespace Lab3
{
    class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }
        public void Add(Student student)
        {
            if (Root == null)
            {
                Root = new Node(student);
            }
            else
            {
                AddNode(Root, student);
            }
        }
        public void AddNode(Node node, Student student)
        {
            if (student.StudentID < node.Data.StudentID)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(student);
                }
                else
                {
                    AddNode(node.Left, student);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(student);
                }
                else
                {
                    AddNode(node.Right, student);
                }
            }

        }
        public void Traverse(Node node)
        {
            if (node != null)
            {
                Traverse(node.Left);

                Console.WriteLine(

                    $"{node.Data.Surname,-12} {node.Data.Name,-12} {node.Data.Course,-6} {node.Data.StudentID,-8} {node.Data.DataOfBirth:dd.MM.yyyy}"

                );

                Traverse(node.Right);
            }

        }

        public void FindStudentsBornInSpring(Node node)
        {
            if (node != null)
            {
                FindStudentsBornInSpring(node.Left);

                int month = node.Data.DataOfBirth.Month;

                if (month == 3 || month == 4 || month == 5)
                {
                    Console.WriteLine(

                        $"{node.Data.Surname,-12} {node.Data.Name,-12} {node.Data.Course,-6} {node.Data.StudentID,-8} {node.Data.DataOfBirth:dd.MM.yyyy}"
                    );
                }
                FindStudentsBornInSpring(node.Right);

            }

        }
        public void DeleteSpringStudents()
        {
            Root = DeleteRecursive(Root);
        }

        private Node DeleteRecursive(Node node)
        {
            if (node == null)
                return null;

            node.Left = DeleteRecursive(node.Left);
            node.Right = DeleteRecursive(node.Right);

            int month = node.Data.DataOfBirth.Month;

            if (month == 3 || month == 4 || month == 5)
            {
                // 1) листок
                if (node.Left == null && node.Right == null)
                    return null;

                // 2) один нащадок
                if (node.Left == null)
                    return node.Right;

                if (node.Right == null)
                    return node.Left;

                // 3) два нащадки
                Node min = FindMin(node.Right);
                node.Data = min.Data;
                node.Right = DeleteMin(node.Right);

                return node;
            }

            return node;
        }

        private Node FindMin(Node node)
        {
            while (node.Left != null)
                node = node.Left;
            return node;
        }

        private Node DeleteMin(Node node)
        {
            if (node.Left == null)
                return node.Right;

            node.Left = DeleteMin(node.Left);
            return node;
        }
    }
}