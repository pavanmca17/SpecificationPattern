
using FluentDemo.Interface;


namespace FluentDemo
{
    public class Calculator : ICalculation, IResult
    {
        private int _value;
        private int _result;

        private Calculator()
        {

        }

        public static ICalculation WithValue(int value)
        {
            return new Calculator
            {
                _value = value
            };
        }

        public IResult Add(int toAdd)
        {
            this._result = this._value + toAdd;
            return this;
        }

        public IResult Subtract(int toSubtract)
        {
            this._result = this._value - toSubtract;
            return this;
        }

        public IResult Multiple(int toMul)
        {
            this._result = this._value * toMul;
            return this;
        }

        public int Result() => this._result;
    }
}
