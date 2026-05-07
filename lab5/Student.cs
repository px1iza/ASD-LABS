namespace lab5
{
    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }
        public StudyForm StudyForm { get; set; }

        public Student(string surname, string name, string faculty, int course, StudyForm studyForm)
        {
            Surname = surname;
            Name = name;
            Faculty = faculty;
            Course = course;
            StudyForm = studyForm;
        }
        public void Print()
        {
            Console.WriteLine($"{Surname} {Name}, {Faculty}, курс: {Course}, форма: {StudyForm}");
        }
    }
}