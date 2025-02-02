using exam.Questions;

namespace exam.Exam
{
    public class FinalExam : BaseExam
    {
        MCQ[] MCQuestions;
        TrueFalse[] TrueFalseQuestions;
        public FinalExam(int examTime, int numOfQustions)
            : base(examTime, numOfQustions)
        {
            MCQuestions = new MCQ[numOfQustions / 2];
            TrueFalseQuestions = new TrueFalse[numOfQustions / 2];
        }
        

    }

}
