using System;

namespace Prototype.Interface
{
    // Дженерик интерфейс для реализации паттерна "Прототип"
    public interface IMyCloneable
    {
        IMyCloneable Clone();
    }
}