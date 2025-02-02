namespace exam.Questions
{
    internal class BaseQuestion
    {
        private int header {  get; set; }

        protected string body;
        public string Body
        {
            get => body;
            set => body = value;
        }

        protected int mark;

        public int Mark
        {
            get => mark;
            set => mark = value >= 0 ? value : 2;
        }

        protected BaseQuestion(int header, string body, int mark)
        {
            this.header = header;
            this.body = body;
            this.mark = mark;
        }



    }
}
