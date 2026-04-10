using Database;
using Repository;

public class Program
{
    
    public static void Main(string[] args)
    {
        using (var myContext = new WeatherStationContext())
        {
            myContext.Database.EnsureCreated();

            IUserRepository user = new UserRepository(myContext);
            var temp = user.GetUser(1);

            Console.WriteLine(temp.Name);
        }
        
    }
}