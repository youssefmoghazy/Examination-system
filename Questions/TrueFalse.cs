
namespace exam.Questions
{
    internal class TrueFalse :BaseQuestion
    {
        internal Answer.Answer rightAnswer { get; set; }
        public TrueFalse(string body, int mark, Answer.Answer answer)
            : base(2, body, mark)
        {
            this.rightAnswer = answer;
        }

    }
}
