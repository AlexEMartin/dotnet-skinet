
using System.Linq.Expressions;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> Criteria { get; }
        List<Expression<Func<T, object>>> Includes { get; }

        // OrderBy is a function that takes an expression of type T and returns an object
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }

        // Pagination
        int Take { get; }
        int Skip { get; }
        bool IsPagingEnabled { get; }
        
    }
}