namespace Student
{
    internal class Program
    {
        /// <summary>
        /// Represents the main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            Student[] students = new Student[10];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                students[i].Name = $"Student{i + 1}";
                students[i].Id = $"ID{i + 1}";
                students[i].Age = 20 + i;
            }

            foreach (Student student in students)
            {
                Console.WriteLine(student.GetInformation());
            }

            Console.ReadLine();
        }
    }
}