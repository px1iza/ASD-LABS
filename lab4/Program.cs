namespace Lab4
{
    class Program
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new Student { Surname = "Рабірох", Name = "Єлизавета", Form = StudyForm.Budget },
                new Student { Surname = "Петренко", Name = "Марія", Form = StudyForm.Contract },
                new Student { Surname = "Коваленко", Name = "Андрій", Form = StudyForm.Budget }
            };

            // 1 завдання
            System.Console.WriteLine("Масив до сортування вибіркою:");
            Student.Print(students);
            Student.SelectionSort(students);
            System.Console.WriteLine("\nМасив після сортування вибіркою:");
            Student.Print(students);

            // 2 завдання
            DoublyLinkedList list = new DoublyLinkedList();
            list.Add(new Student { Surname = "Рабірох", Name = "Єлизавета", Form = StudyForm.Budget });
            list.Add(new Student { Surname = "Петренко", Name = "Марія", Form = StudyForm.Contract });
            list.Add(new Student { Surname = "Коваленко", Name = "Андрій", Form = StudyForm.Budget });
            System.Console.WriteLine("\nДвонаправлений список:");
            list.Print();
            System.Console.WriteLine("\nВідсортований двонаправлений список:");
            list.SelectionSortBySurname();
            list.Print();

            // 3 завдання
            Student[] students2 = new Student[]
            {
                new Student { Surname = "Рабірох", Name = "Єлизавета", Form = StudyForm.Budget },
                new Student { Surname = "Петренко", Name = "Марія", Form = StudyForm.Contract },
                new Student { Surname = "Коваленко", Name = "Андрій", Form = StudyForm.Budget }
            };
            System.Console.WriteLine("\nМасив до QuickSort:");
            Student.Print(students2);
            Student.QuickSort(students2, 0, students2.Length - 1);
            System.Console.WriteLine("\nМасив після QuickSort:");
            Student.Print(students2);
        }
    }
}