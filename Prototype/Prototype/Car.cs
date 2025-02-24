using Prototype.Interface;
using System.Xml.Linq;

namespace Prototype
{
    // Производный класс Car, наследуется от Transport
    public class Car : Transport
    {
        public int Wheels { get; set; }

        public Car(string type, int wheels) : base(type)
        {
            Wheels = wheels;
        }

        public override IMyCloneable Clone()
        {
            return new Car(Type, Wheels);
        }
    }
}