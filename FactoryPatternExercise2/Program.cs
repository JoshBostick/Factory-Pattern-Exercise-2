namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database do you want to use: a List, SQL, or Mongo?");
            var answer = Console.ReadLine().ToLower();

            var database = DataAccessFactory.GetDataAccessType(answer);
            database.LoadData();
            database.SaveData();
        }
    }
}
