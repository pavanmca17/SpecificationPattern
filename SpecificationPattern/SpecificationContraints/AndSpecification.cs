using SpecificationPattern.Interface;

namespace SpecificationPattern
{
    public class AndSpecification<T> : ISpecification<T> where T :class
    {
        public ISpecification<T> Left { get; set; }
        public ISpecification<T> Right { get; set; }      

        public bool IsSatisfiedBy(T item) => Left.IsSatisfiedBy(item) && Right.IsSatisfiedBy(item);
    }

   

    
}
