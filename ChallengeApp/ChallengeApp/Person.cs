namespace ChallengeApp
{
    public abstract class Person //: System.Object
    {
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = true;
        }

        public Person(string name, string surname, bool gender)
        {
            this.Name = name;
            this.Surname= surname;
            this.Gender = gender;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public bool Gender { get; private set; } // true if men, false if wooman
    }
}
