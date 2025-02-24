using Prototype;
using Prototype.Interface;

namespace Prototype
{
    // Производный класс Truck
    public class Truck : Car
    {
        public int Сarrying { get; set; }

        public Truck(string type, int wheels, int carrying)
            : base(type, wheels)
        {
            Сarrying = carrying;
        }

        public override IMyCloneable Clone()
        {
            return new Truck(Type, Wheels, Сarrying);
        }
    }
}