using exam.Answer;

namespace exam.Questions
{
    internal class MCQ : BaseQuestion
    {
        Answer.Answer[] AnswerList = new Answer.Answer[3];

        Answer.Answer rightAnswer;
        public MCQ(string body, int mark, Answer.Answer[] answerList, Answer.Answer rightAnswer)
            : base(1, body, mark)
        {
            AnswerList = answerList;
            this.rightAnswer = rightAnswer;
        }
    }
}
