namespace ChallengeApp
{
    public class Person : System.Object
    {
        public string Name { get; private set; }

        protected int counter;
   
        public Person(string name)
        {
            this.Name = name;
        }
    }
}
