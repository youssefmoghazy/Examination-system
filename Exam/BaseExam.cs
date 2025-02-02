using exam.Questions;

namespace exam.Exam
{
    public class BaseExam
    {
        protected int examTime;
        protected int numOfQustions;

        public int NumOfQustions
        {
            get => numOfQustions;
            set => numOfQustions = value >= 0 ? value : 2;
        }

        public int ExamTime
        {
            get => examTime;
            set => examTime = value;
        }

        public BaseExam() { }

        public BaseExam(int examTime, int numOfQustions)
        {
            this.examTime = examTime;
            this.numOfQustions = numOfQustions;
        }
    }



}
