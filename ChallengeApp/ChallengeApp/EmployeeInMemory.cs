namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value. You can use numbers from 0 to 100.");
            }
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            AddGrade(result);
        }

        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            AddGrade(result);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter. You can use: 'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e'");
            }
        }

        public override void AddGrade(string grade)
        {
            if (grade.Length == 1)
            {
                char.TryParse(grade, out char tmp);
                this.AddGrade(tmp);
            }
            else if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float!");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            
            return statistics;
        }
    }
}