using Database;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
namespace Database;

public class Program
{
    
    public static void Main(string[] args)
    {
        using (var myContext = new WeatherStationContext())
        {
            myContext.Database.EnsureCreated();
        }
    }
}