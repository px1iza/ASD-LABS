namespace Lab4
{
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public StudyForm Form { get; set; }

        public Student(string name, string surname, StudyForm form)
        {
            Name = name;
            Surname = surname;
            Form = form;
        }
        public static void Print(Student[] arr)
        {
            foreach (var item in arr)
            {
                System.Console.WriteLine($"{item.Surname} {item.Name} - {item.Form}");
            }
        }
    }
}