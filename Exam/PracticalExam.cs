using exam.Questions;

namespace exam.Exam
{
    internal class PracticalExam : BaseExam
    {
        MCQ[] MCQuestions;
        public PracticalExam(int examTime, int numOfQustions)
            : base(examTime, numOfQustions)
        {
            MCQuestions = new MCQ[numOfQustions ];
        }


    }
}
