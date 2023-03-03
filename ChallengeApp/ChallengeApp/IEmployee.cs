
namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        Statistics GetStatistics();
        void AddGrade(long grade);
        void AddGrade(int grade);
        void AddGrade(decimal grade);
        void AddGrade(double grade);
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(char grade);

    }
}
