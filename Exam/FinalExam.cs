using exam.Questions;

namespace exam.Exam
{
    public class FinalExam : BaseExam
    {
        
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
            for (int i = 0; i < numOfQustions; i++)
            {
                Console.WriteLine($"Plase enter the type for qusetion number {i+1}" +
                    $":(1 for MCQ , 2 for TrueFalse)");
                int type;
                while (!(int.TryParse(Console.ReadLine(), out type) &&( type == 1 || type == 2)))
                {
                    Console.WriteLine("Retry (type of the question must be 1 or 2):");
                }
                if (type == 1)
                {
                    Console.Clear();
                    Console.WriteLine("MCQ question :");
                    questions[i] = getMCQQuestions(i+1);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("True | False question :");
                    questions[i] = getTureFalseQuestions();
                    Console.Clear();
                }
            }

        }


        internal TrueFalse getTureFalseQuestions()
        {
            Console.WriteLine("Please enter the body of the question:");
            string body = Console.ReadLine();


            Console.WriteLine("Please enter the right answer (Right answer must be 1 for true or 2 for false)");
            int rightAnswer;
            while (!(int.TryParse(Console.ReadLine(), out rightAnswer) && (rightAnswer == 1 || rightAnswer == 2)))
            {
                Console.WriteLine("Retry (Right answer must be 1 or 2):");
            }
            Console.WriteLine("Please enter the mark of the question");
            int mark;
            while (!(int.TryParse(Console.ReadLine(), out mark) && mark > 0))
            {
                Console.WriteLine("Retry (Mark must be greater than 0):");
            }

            TrueFalse TrueFalseuestion = new TrueFalse(body, mark, new Answer.Answer(rightAnswer, rightAnswer == 1 ? "true" : "false"));

            return TrueFalseuestion;
        }

        public override void showExam()
        {
            int fullmark = 0;
            int result = 0;
            for (int i = 0; i < questions.Length; i++)
            {
                if (questions[i] is MCQ)
                {
                    MCQ mcqQuestion = questions[i] as MCQ;
                    showMCQuestion(ref result, ref fullmark, mcqQuestion);
                }
                else if (questions[i] is TrueFalse)
                {
                    TrueFalse TFQuestion = questions[i] as TrueFalse;
                    showTFQuestion(ref result, ref fullmark, TFQuestion);
                }
            }
            Console.WriteLine("=================================================");
            Console.WriteLine($"You got {result} / {fullmark}");
        }

        internal void showTFQuestion(ref int result, ref int fullmark, TrueFalse TFQuestion)
        {
            Console.WriteLine($"MCQ question:       mark({TFQuestion.Mark})");
            Console.WriteLine(TFQuestion);
            Console.WriteLine("True         False");
            Console.WriteLine("---------------------------------------------");
            int theAnswer;
            while (!(int.TryParse(Console.ReadLine(), out theAnswer) &&( theAnswer == 1 || theAnswer ==2)))
            {
                Console.WriteLine("Retry (Right answer must be 1 or 2):");
            }
            fullmark += TFQuestion.Mark;
            if (TFQuestion.rightAnswer.AnswerId == theAnswer)
            {
                result += TFQuestion.Mark;
            }
        }
    }

}
