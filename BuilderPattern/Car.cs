using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Car
    {
        public string Name { get; set; }
        public string Frame { get; set; }
        public int EnginePower { get; set; }
        public int WheelRadius { get; set; }
        public Transmission GearsBox{ get; set; }
        public override string ToString()
        {
            return "Name " + Name + "\nFrame " + Frame + "\nEngine power(h.p.) " + EnginePower.ToString() + "\nWheel radius " + WheelRadius.ToString() + "\nTransmission " + GearsBox.GetGears().ToString() + " "+ GearsBox.GetClutchType() ;
        }

    }
    public struct Transmission
    {
        public Transmission(int gears, string ClutchType)
        {
            this.gears = gears;
            this.ClutchType = ClutchType;
        }
        public int gears;
        public string ClutchType;
        public void SetGears(int val) { gears = val; }
        public int  GetGears() { return gears; }
        public void SetClutchType(string val) {  ClutchType = val; }
        public string GetClutchType() {  return ClutchType; }
    }
}
