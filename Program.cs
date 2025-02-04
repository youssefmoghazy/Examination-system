using System.Diagnostics;
using exam.Exam;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject.Subject sub = new Subject.Subject(10,"c#");
            sub.CreateExam();
            Console.Clear();
            Console.WriteLine("Do you want to start the exam now? ( y | n )");
            
            if(char.Parse(Console.ReadLine())== 'y')
            {
                Console.Clear() ;
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                sub.Exam.showExam();
                Console.WriteLine($"The elapsed Time = {sw.Elapsed}");

            }


        }
    }
}
