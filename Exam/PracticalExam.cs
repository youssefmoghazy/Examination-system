using exam.Questions;

namespace exam.Exam
{
    internal class PracticalExam : BaseExam
    {

        public PracticalExam(int examTime, int numOfQustions)
            : base(examTime, numOfQustions)
        {
            questions = new MCQ[numOfQustions];
            for (int i = 0; i < numOfQustions; i++)
            {
                Console.Clear();
                Console.WriteLine("MCQ question :");
                questions[i] = getMCQQuestions(i + 1);
            }
        }
        public override void showExam()
        {
            int fullmark = 0;
            int result = 0;
            for (int i = 0; i < questions.Length; i++)
            {
                MCQ mcqQuestion = questions[i] as MCQ;
                showMCQuestion(ref result,ref fullmark, mcqQuestion);
            }
            Console.WriteLine("=================================================");
            Console.WriteLine($"You got {result} / {fullmark}");
            for (int i = 0; i < questions.Length; i++)
            {
                MCQ mcqQuestion = questions[i] as MCQ;
                Console.WriteLine("----------------");
                Console.WriteLine(mcqQuestion);
                Console.WriteLine($"the right answer : {mcqQuestion.rightAnswer.AnswerText}");
            }
        }
    }
}
