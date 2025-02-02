namespace exam.Answer
{
    internal class Answer
    {
        private int AnswerId { get; set; }
        private string AnswerText { get; set; }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
    }
}
