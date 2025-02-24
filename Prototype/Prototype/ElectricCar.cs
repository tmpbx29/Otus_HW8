using Prototype.Interface;

namespace Prototype
{
    // Производный класс ElectricCar
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }

        public ElectricCar(string type, int wheels, int capacity)
            : base(type, wheels)
        {
            BatteryCapacity = capacity;
        }

        public override IMyCloneable Clone()
        {
            return new ElectricCar(Type, Wheels, BatteryCapacity);
        }
    }
}