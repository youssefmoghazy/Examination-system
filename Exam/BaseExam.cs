using exam.Questions;

namespace exam.Exam
{
    public abstract class BaseExam
    {
        internal BaseQuestion[] questions;
        private int examTime {  get; set; }
        private int numOfQustions { get; set; }

        public int NumOfQustions
        {
            get => numOfQustions;
            set => numOfQustions = value > 0 ? value : 0;
        }

        public int ExamTime
        {
            get => examTime;
            set => examTime = value > 0 ? value : 1;
        }


        public BaseExam() { }

        public BaseExam(int examTime, int numOfQustions)
        {
            this.examTime = examTime;
            this.numOfQustions = numOfQustions;
        }
        internal MCQ getMCQQuestions(int questionNum)
        {
            Console.WriteLine($"Please enter the body of the question {questionNum}:");
            string? body = Console.ReadLine();

            Answer.Answer[] AnswerList = new Answer.Answer[3];

            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.Write($"Enter answer {i + 1}: ");
                string ans = Console.ReadLine() ?? string.Empty;
                AnswerList[i] = new Answer.Answer(i, ans);
            }
            Console.WriteLine("Please enter the right answer (Right answer must be 1, 2, or 3)");
            int rightAnswer;
            while (!(int.TryParse(Console.ReadLine(), out rightAnswer) && rightAnswer >= 1 && rightAnswer <= 3))
            {
                Console.WriteLine("Retry (Right answer must be 1, 2, or 3):");
            }
            Console.WriteLine("Please enter the mark of the question");
            int mark;
            while (!(int.TryParse(Console.ReadLine(), out mark) && mark > 0))
            {
                Console.WriteLine("Retry (Mark must be greater than 0):");
            }

            MCQ MCQuestion = new MCQ(body, mark, AnswerList, AnswerList[rightAnswer - 1]);

            return MCQuestion;
        }

        public abstract void showExam();

        internal void showMCQuestion(ref int result , ref int fullmark , MCQ mcqQuestion)
        {
            Console.WriteLine($"MCQ question:       mark({mcqQuestion.Mark})");
            Console.WriteLine(mcqQuestion.Body);
            for (int j = 0; j < 3; j++)
            {
                Console.Write(mcqQuestion.AnswerList[j].AnswerText + "   ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            int theAnswer;
            while (!(int.TryParse(Console.ReadLine(), out theAnswer) && theAnswer >= 1 && theAnswer <= 3))
            {
                Console.WriteLine("Retry (Right answer must be 1, 2, or 3):");
            }
            fullmark += mcqQuestion.Mark;
            if (mcqQuestion.AnswerList[ theAnswer -1] == mcqQuestion.rightAnswer)
            {
                result += mcqQuestion.Mark;
            }
        }
    }



}
