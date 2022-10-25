using FileHandling;

namespace FileHamdling
{
    public class StudentManager
    {
        List<Student> Students = new List<Student>();
        public void ReadFromFile()
        {
            string[] data = File.ReadAllLines(@"C:\Users\Treehays\Documents\CLH\Projects\FileHamdling\allmystudentslist.txt");

            foreach (string s in data)
            {
                Students.Add(Student.ToStudent(s));
            }
        }
        public void Register()
        {
            // var students = new List<string>();
            var flag = true;
            while (flag)
            {
                Console.Write("Enter your Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your Email: ");
                string email = Console.ReadLine();//User Input

                var student = new Student(name, email);
                Students.Add(student);//adding to list of string
                WriteToFile(student.ToString());

                Console.WriteLine("Do you want to add another Student? Y/N");//condition for repetition 
                string option = Console.ReadLine();
                flag = option.ToLower() == "y" ? true : false;
            }
        }
        public static void WriteToFile(string student)
        {
            File.AppendAllText(@"C:\Users\Treehays\Documents\CLH\Projects\FileHamdling\allmystudentslist.txt", student);
        }
    }
}