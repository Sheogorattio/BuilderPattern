using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        public Car makeDaewoo(VehicleBuilder builder)
        {
            builder.SetName("Daewoo Lanos");
            builder.SetWheelRadius(13);
            builder.SetTransmission(5, "Manual");
            builder.SetFrameType("sedan");
            builder.SetEnginePower(98);
            return builder.getResult();
        }
        public Car makeFordProbe(VehicleBuilder builder)
        {
            builder.SetName("Ford Probe");
            builder.SetWheelRadius(14);
            builder.SetTransmission(4, "Auto");
            builder.SetFrameType("Coupe");
            builder.SetEnginePower(160);
            return builder.getResult();
        }
        public Car makeUAZPetriot(VehicleBuilder builder)
        {
            builder.SetName("UAZ Patriot");
            builder.SetWheelRadius(16);
            builder.SetTransmission(4, "Manual");
            builder.SetFrameType("Universal");
            builder.SetEnginePower(120);
            return builder.getResult();
        }
        public Car makeHUndaiGetz(VehicleBuilder builder)
        {
            builder.SetName("Hundai Getz");
            builder.SetWheelRadius(13);
            builder.SetTransmission(4, "Auto");
            builder.SetFrameType("Hatchback");
            builder.SetEnginePower(66);
            return builder.getResult();
        }
    }
}