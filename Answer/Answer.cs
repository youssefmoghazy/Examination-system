namespace exam.Answer
{
    internal class Answer 
    {
        internal int AnswerId { get; set; }
        internal string AnswerText { get; set; }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public override bool Equals(object? obj)
        {
            Answer? ans = obj as Answer;
            if (ans == null) return false;
            return (AnswerId == ans.AnswerId);
        }
    }
}
