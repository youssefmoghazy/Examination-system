using exam.Answer;

namespace exam.Questions
{
    internal class MCQ : BaseQuestion
    {
        internal Answer.Answer[] AnswerList = new Answer.Answer[3];

        internal Answer.Answer rightAnswer;
        public MCQ(string body, int mark, Answer.Answer[] answerList, Answer.Answer rightAnswer)
            : base(1, body, mark)
        {
            AnswerList = answerList;
            this.rightAnswer = rightAnswer;
        }
    }
}
