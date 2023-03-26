using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        Car makeDaewoo(VehicleBuilder builder)
        {
            builder.SetName("Daewoo Lanos");
            builder.SetWheelRadius(13);
            builder.SetTransmission(5, "Manual");
            builder.SetFrameType("sedan");
            
        }
    }
}