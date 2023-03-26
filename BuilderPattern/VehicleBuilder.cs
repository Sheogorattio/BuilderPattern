using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface VehicleBuilder
    {
        void SetName(string name);
        void SetEnginePower(int power);
        void SetTransmission(int speeds, string clutchType);
        void SetWheelRadius(int rad);
        void SetFrameType(string frame);
        Car getResult();
        void reset();
    }

    public class Builder:VehicleBuilder
    {
        public Car car = new Car();

        public void SetEnginePower(int power)
        {
            car.EnginePower = power;
        }

        public void SetFrameType(string frame)
        {
            car.Frame = frame;
        }

        public void SetTransmission(int speeds, string clutchType)
        {
            car.GearsBox = new Transmission(speeds, clutchType);
        }

        public void SetWheelRadius(int rad)
        {
           car.WheelRadius = rad;
        }

        public void reset() { car = new Car();}
        public Car getResult() { return car; }

        public void SetName(string name)
        {
            car.Name = name;
        }
    }
}
