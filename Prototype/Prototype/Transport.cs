using Prototype.Interface;

namespace Prototype
{
    // Базовый класс Transport
    public class Transport : IMyCloneable, ICloneable
    {
        public string Type { get; set; }

        public Transport(string type)
        {
            Type = type;
        }

        public virtual IMyCloneable Clone()
        {
            return new Transport(Type);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}