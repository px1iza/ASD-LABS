namespace lab5
{
    class Program
    {
        static void Main()
        {
            Student[] students = new Student[20];
            int size = 0;
            InsertSorted(students, ref size, new Student("Іваненко", "Оля", "ФКНТ", 1, StudyForm.Budget));
            InsertSorted(students, ref size, new Student("Петренко", "Іра", "ФКНТ", 1, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Сидоренко", "Аня", "ФКНТ", 2, StudyForm.Budget));
            InsertSorted(students, ref size, new Student("Коваль", "Марія", "ФКНТ", 2, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Бондар", "Ілля", "ФКНТ", 3, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Ткаченко", "Олег", "ФКНТ", 3, StudyForm.Budget));
            InsertSorted(students, ref size, new Student("Мельник", "Анна", "ФКНТ", 3, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Шевченко", "Катя", "ФКНТ", 3, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Лисенко", "Ігор", "ФКНТ", 4, StudyForm.Budget));
            InsertSorted(students, ref size, new Student("Гриценко", "Юля", "ФКНТ", 4, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Данилюк", "Оксана", "ФКНТ", 5, StudyForm.Budget));
            InsertSorted(students, ref size, new Student("Романюк", "Саша", "ФКНТ", 5, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Кравець", "Іра", "ФКНТ", 6, StudyForm.Budget));
            InsertSorted(students, ref size, new Student("Олійник", "Назар", "ФКНТ", 6, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Паламарчук", "Ілона", "ФКНТ", 1, StudyForm.Budget));
            InsertSorted(students, ref size, new Student("Савченко", "Макс", "ФКНТ", 2, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Мороз", "Ірина", "ФКНТ", 3, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Козак", "Артем", "ФКНТ", 4, StudyForm.Budget));
            InsertSorted(students, ref size, new Student("Білик", "Оля", "ФКНТ", 5, StudyForm.Contract));
            InsertSorted(students, ref size, new Student("Яремчук", "Ігор", "ФКНТ", 6, StudyForm.Budget));

            Console.WriteLine("Список студентів:");
            for (int i = 0; i < size; i++)
                students[i].Print();

            int result = CountContractThirdCourse(students, size);
            Console.WriteLine();
            Console.WriteLine(result == -1
                ? "Таких студентів не знайдено"
                : $"Кількість студентів контракту на 3 курсі: {result}");

            BST tree = new BST();
            tree.Root = tree.InsertRoot(tree.Root, new Student("Іваненко", "Оля", "ФКНТ", 1, StudyForm.Budget));
            tree.PrintLevelOrder();
            tree.Root = tree.InsertRoot(tree.Root, new Student("Петренко", "Іра", "ФКНТ", 2, StudyForm.Contract));
            tree.PrintLevelOrder();
            tree.Root = tree.InsertRoot(tree.Root, new Student("Сидоренко", "Аня", "ФКНТ", 3, StudyForm.Budget));
            tree.PrintLevelOrder();
            tree.Root = tree.InsertRoot(tree.Root, new Student("Коваль", "Марія", "ФКНТ", 4, StudyForm.Contract));
            tree.PrintLevelOrder();

            string key = "Сидоренко";

            Node found = tree.Search(tree.Root, key);
            Console.WriteLine();
            if (found != null)
                found.Data.Print();
            else
                Console.WriteLine("Не знайдено");
        }

        static int CountContractThirdCourse(Student[] students, int size)
        {
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (students[i].Course == 3 && students[i].StudyForm == StudyForm.Contract)
                    count++;
            }
            return count == 0 ? -1 : count;
        }

        static void InsertSorted(Student[] students, ref int size, Student newStudent)
        {
            int i = size - 1;

            while (i >= 0 && students[i].Course > newStudent.Course)
            {
                students[i + 1] = students[i];
                i--;
            }
            students[i + 1] = newStudent;
            size++;
        }
    }
}
