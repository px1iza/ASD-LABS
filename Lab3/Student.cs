namespace Lab3
{
    class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }
        public uint StudentID { get; set; }
        public DateTime DataOfBirth { get; set; }

        public Student(string surname, string name, int course, uint studentID, DateTime dataOfBirth)
        {
            Surname = surname;
            Name = name;
            Course = course;
            StudentID = studentID;
            DataOfBirth = dataOfBirth;
        }
    }

}