namespace exam.Questions
{
    public class BaseQuestion
    {
        private int header {  get; set; }

        private string body;
        public string Body
        {
            get => body;
            set => body = value;
        }

        private int mark;

        public int Mark
        {
            get => mark;
            set => mark = value >= 0 ? value : 2;
        }

        public BaseQuestion(int header, string body, int mark)
        {
            this.header = header;
            this.body = body;
            this.mark = mark;
        }
        public override string ToString()
        {
            return Body;
        }
    }
}
