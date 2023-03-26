using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Car
    {
        public Car() { }
        public string Name { get; set; }
        public string Frame { get; set; }
        public int EnginePower { get; set; }
        public int WheelRadius { get; set; }
        public Transmission GearsBox{ get; set; }

    }
    public struct Transmission
    {
        public int gears;
        public string ClutchType;
        public void SetGears(int val) { gears = val; }
        public void SetClutchType(string val) {  ClutchType = val; }
    }
}
