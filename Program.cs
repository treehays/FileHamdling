using System;
using System.IO;
using System.Text;
namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
        }
       
    }
}





/*
using System;
using System.IO;
using System.Text;
namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = Register();
            WriteToFile(students);
            ReadFromFile();
        }
        public static List<string> Register()
        {
            var students = new List<string>();
            var flag = true;
            while (flag)
            {
                Console.Write("Enter your Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your Email: ");
                string email = Console.ReadLine();//User Input
                students.Add(new Student(name, email).ToString());//adding to list of string
                Console.WriteLine("Do you want to add another Student? Y/N");//condicction for repition
                string option = Console.ReadLine();
                flag = option.ToLower() == "y" ? true : false;
            }
            return students;
        }
        public static void WriteToFile(List<string> student)
        {
            File.AppendAllText(@"C:\Users\Treehays\Documents\CLH\Projects\FileHamdling\allmystudentslist.txt", String.Join('\n', student));
        }
        public static void ReadFromFile()
        {
            string data = File.ReadAllText(@"C:\Users\Treehays\Documents\CLH\Projects\FileHamdling\allmystudentslist.txt");
            string[] arr = data.Split('\n');
            foreach (string s in arr)
            {
                string[] d = s.Split('\t');
                Console.WriteLine(d[0]);
                Console.WriteLine(d[1]);
                Student student = new Student(d[0], d[1]);
                string name = "ayo";
                if (student.FullName == name)
                {
                    System.Console.WriteLine("User Exist.");
                    break;
                }
                else
                {
                    System.Console.WriteLine("User not fund");
                }
            }
        }
    }
}





// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// FileInfo fileInfo = new FileInfo(@"C:\Users\Treehays\Documents\CLH\Projects\FileHamdling\fileclass.txt");
// Console.WriteLine(fileInfo.FullName);
// StreamWriter text = fileInfo.AppendText();
// text.WriteLine("This is a test.\nThis is a next line.");
// text.Flush();
// text.Close();
// fileInfo.CopyTo(@"C:\Users\Treehays\Documents\CLH\Projects\FileHamdling\newfileclass.txt");


// string dpath1 = @"C:\Users\Treehays\Documents\CLH\Projects\FileHamdling\newfileclass - Copy.txt";
// string directo = @"C:\Users\Treehays\Documents\CLH\Projects\FileHamdling";
// // File.Create(dpath);
// File.WriteAllText(@"C:\Users\Treehays\Documents\CLH\Projects\FileHamdling\newfileclass.txt","this is a sample text");
// for (int i = 0; i < 500000; i++)
// {
// File.AppendAllText(@"C:\Users\Treehays\Documents\CLH\Projects\FileHamdling\newfileclass.txt","\nthis is a sample text");
// }
// Stream s = new FileStream(path,FileAccess.ReadWrite);
// FileInfo fileInfo = new FileInfo(dpath);
// FileStream fileStream = new FileStream(dpath,FileAccess.ReadWrite,FileMode.Append);

// foreach (var item in File.ReadLines(path))
// {
//     System.Console.WriteLine(item);
// }



// // var text =  File.ReadAllText(dpath);
// // System.Console.WriteLine(text);
// var text1 =  File.ReadAllLines(dpath);
// foreach (var item in text1)
// {
// System.Console.WriteLine(item);

// appenAll line
/*
append all tex
read all line 
read all text
filestream// setting permission
*/

/*
Abdsolut path fuull
relative direct
Asynchronoes start new afyertv-cy
synchri=niui



*/
// }