namespace FileHandling
{
    public class Student
    {
        public string FullName { get; set; }
        public string Email { get; set; }

        public Student(string fullName, string email)
        {
            FullName = fullName;
            Email = email;
        }

        public override string ToString()
        {
            return $"{FullName}\t{Email}";
        }

        public static Student ToStudent(string str)
        {
            string[] d = str.Split('\t');
             string fullName = d[0];
             string email = d[1];
            Student student = new Student(fullName, email);
            return student;
        }
    }
}