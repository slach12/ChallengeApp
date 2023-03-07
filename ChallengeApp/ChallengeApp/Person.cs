namespace ChallengeApp
{
    public abstract class Person : System.Object
    {
        protected string Surname { get; private set; }
        protected string Name { get; private set; }
        protected  char Sex { get; private set; }
      

        protected int counter;
   
        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
        }
    }
}
