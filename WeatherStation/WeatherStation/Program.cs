using Database;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using WeatherStation;

namespace WeatherStation;

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