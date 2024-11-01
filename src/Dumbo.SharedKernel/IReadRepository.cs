using Ardalis.Specification;

namespace Dumbo.SharedKernel;

/// <summary>
/// An abstraction for read only persistence operations, based on Ardalis.Specification.
/// Use this primarily to fetch trackable domain entities, not for custom queries.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
    
    Task<TResult?> ProjectToFirstOrDefaultAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken);
    Task<List<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken);
    Task<PagedResponse<TResult>> ProjectToListAsync<TResult>(ISpecification<T> specification, BaseFilter filter, CancellationToken cancellationToken);
}
