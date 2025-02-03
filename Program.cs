using exam.Exam;

namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject.Subject sub = new Subject.Subject(10,"c#");
            sub.CreateExam();
        }
    }
}
