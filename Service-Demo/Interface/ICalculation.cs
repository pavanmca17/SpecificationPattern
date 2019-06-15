using FluentDemo.Interface;

namespace FluentDemo.Interface
{
    public interface ICalculation
    {
        IResult Add(int toAdd);
        IResult Subtract(int toSubtract);
        IResult Multiple(int toMul);
    }
}
