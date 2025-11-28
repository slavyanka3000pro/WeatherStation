using System.Diagnostics.Metrics;

namespace Database;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    private static int counter;

    public User(string name, int id)
    {
        Name = name;
        Id = id;

        counter++;
    }
}
