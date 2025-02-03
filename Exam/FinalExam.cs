using exam.Questions;

namespace exam.Exam
{
    public class FinalExam : BaseExam
    {
        BaseQuestion[] questions;
        public FinalExam(int examTime, int numOfQustions)
            : base(examTime, numOfQustions)
        {
            questions = new BaseQuestion[numOfQustions];
            //-------------------V3.0--------------------- 
            //questions[1] = new TrueFalse("hello", 2);
            // so we should loop n time and ask the admin to 
            // enter the type of question and create new exam using one of the two functions
            // implement getTrueFalseQuestion function
            // search for time count in c# 
            // -----------------------------------------
        }
        

    }

}
