using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileWorkingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   File.Create("demofile.txt");
            //File.Delete("demofile.txt");

            //File.Create("C:\\Users\\hp\\Desktop\\demo1.txt");
            //File.Create(@"C:\Users\hp\Desktop\demo2.txt");
            // File.Create("C:/Users/hp/Desktop/demo1.txt");
            //           Console.WriteLine("File created....");


            //Directory.CreateDirectory("C:/Users/hp/Desktop/Tricom");


            //Console.WriteLine("Directory created....");

            //File.WriteAllText("demo.txt", "This is a demo file");
            //Console.WriteLine("done");

            //IEnumerable<string> dirs=Directory.EnumerateDirectories(@"D:\AllDemos\Tricom\FileWorkingDemo\FileWorkingDemo\");
            //foreach (var item in dirs)
            //{
            //    Console.WriteLine(item);
            //}

            //After completing first task then only start next task means synchronous manner

            //I am doing a task, I have completed my task the remaining task is to be completed by someone else, and then again the remaining will be done by me
            //but in between I will start with next task, this is asynchronous

            //FileCreate();
            //FileRead
           //FileAppend




           
            

            Console.Read();




        }

        static void FileAppend()
        {

            FileStream fs = new FileStream("demofile3.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Appending the file uisng FileMode.Append aand FileAccess.Write");
            sw.Close();
            fs.Close();
        }
        static void FileRead() 
        {
            FileStream fs = new FileStream("demofile3.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string contents = sr.ReadToEnd();
            Console.WriteLine(contents);
            sr.Close();
            fs.Close();


        }

        static void FileCreate()
        {
            FileStream fs = new FileStream("demofile3.txt", FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is a file I am writing.....");
            sw.Flush();//if anything is in the buffer, it will also be written to the file
            sw.Close();
            fs.Close();
            Console.WriteLine("File created and contents written to file");

        }
    }
}
