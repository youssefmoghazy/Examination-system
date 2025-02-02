using exam.Exam;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int examTime = int.Parse(Console.ReadLine());

            int numOfquestion = int.Parse(Console.ReadLine());

            FinalExam finalExam = new FinalExam(examTime, numOfquestion);

        }
    }
}
