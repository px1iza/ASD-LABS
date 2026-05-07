namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Elizaveta", "Rabirokh", 2, 123456, new DateTime(2007, 4, 21));
            Student student2 = new Student("Dmitry", "Shevchenko", 3, 654321, new DateTime(2006, 9, 15));
            Student student3 = new Student("Anna", "Petrova", 1, 111111, new DateTime(2008, 1, 10));

            BinaryTree tree = new BinaryTree();
            tree.Add(student1);
            tree.Add(student2);
            tree.Add(student3);
            Console.WriteLine("In-order Traversal:");
            tree.Traverse(tree.Root);

            Console.WriteLine("\nStudents born in spring:");
            tree.FindStudentsBornInSpring(tree.Root);

            tree.DeleteSpringStudents();
            Console.WriteLine("\nДерево після видалення студентів, народжених навесні:");
            tree.Traverse(tree.Root);


        }
    }
}