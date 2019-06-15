using SpecificationPattern.Interface;


namespace SpecificationPattern
{
    public class NotSpecification<T> : ISpecification<T> where T : class
    {
        public ISpecification<T> Specification { get; set; }       
        public bool IsSatisfiedBy(T item) => !Specification.IsSatisfiedBy(item);
    }
}
