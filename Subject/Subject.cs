using System.Xml.Linq;
using exam.Exam;

namespace exam.Subject
{
    internal class Subject
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value > 0 ? value :0; }
        }

        private string Name {  get; set; }

        internal BaseExam Exam {  get; set; }

        public Subject(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public void CreateExam()
        {
            Console.WriteLine("Please enter tge type of the exam you" +
                " want to create (1 for practical , 2 for final): ");
            int type;
            while (!(int.TryParse(Console.ReadLine(),out type) && type ==1 || type ==2))
            {
                Console.WriteLine("retry (1 for practical , 2 for final)");
            }

            Console.WriteLine("please enter the time of the exam you want to create : ");
            int timeInMin;
            while (!(int.TryParse(Console.ReadLine(), out timeInMin) && type > 0))
            {
                Console.WriteLine("retry (Time must be greater than 0)");
            }

            Console.WriteLine("please enter the number of questions you want to create : ");
            int numOfQues;
            while (!(int.TryParse(Console.ReadLine(), out numOfQues) && numOfQues > 0))
            {
                Console.WriteLine("retry (number of questions must be greater than 0)");
            }
            if (type == 1)
            {
                Exam = new PracticalExam(timeInMin, numOfQues);

            }
            else
            {
                Exam = new FinalExam(timeInMin, numOfQues);
            }
        }
        
        
    }
}
