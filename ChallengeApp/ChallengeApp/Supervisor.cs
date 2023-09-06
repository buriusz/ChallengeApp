
namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value. You can use numbers from 0 to 100.");
            }
        }

        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.grades.Add(result);
        }

        public void AddGrade(int grade)
        {
            float result = (float)grade;
            this.grades.Add(result);
        }

        public void AddGrade(char grade)
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

        public void AddGrade(string grade)
        {
            switch(grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "-6":
                case "6-":
                    this.grades.Add(95);
                    break;
                case "+5":
                case "5+":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;
                case "+4":
                case "4+":
                    this.grades.Add(65);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;
                case "+3":
                case "3+":
                    this.grades.Add(45);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "-3":
                case "3-":
                    this.grades.Add(35);
                    break;
                case "+2":
                case "2+":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "-2":
                case "2-":
                    this.grades.Add(15f);
                    break;
                case "+1":
                case "1+":
                    this.grades.Add(5);
                    break;
                case "-1":
                case "1":
                case "1-":
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("Wrong grade");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count();

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
