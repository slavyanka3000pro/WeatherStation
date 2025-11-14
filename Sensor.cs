using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Sensor
    {
        int Id {  get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        DateTime MeasurementDate;
    }
}
