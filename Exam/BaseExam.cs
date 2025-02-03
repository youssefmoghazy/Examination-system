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
        internal MCQ getMCQQuestions()
        {
            Console.WriteLine("Please enter the body of the question:");
            string? body = Console.ReadLine();

            Answer.Answer[] AnswerList = new Answer.Answer[3];

            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.Write($"Enter answer {i + 1}: ");
                string ans = Console.ReadLine() ?? string.Empty;
                AnswerList[i] = new Answer.Answer(i, ans);
            }

            int rightAnswer;
            while (!(int.TryParse(Console.ReadLine(), out rightAnswer) && rightAnswer >= 1 && rightAnswer <= 3))
            {
                Console.WriteLine("Retry (Right answer must be 1, 2, or 3):");
            }

            int mark;
            while (!(int.TryParse(Console.ReadLine(), out mark) && mark > 0))
            {
                Console.WriteLine("Retry (Mark must be greater than 0):");
            }

            MCQ MCQuestion = new MCQ(body, mark, AnswerList, AnswerList[rightAnswer - 1]);

            return MCQuestion;
        }

    }



}
