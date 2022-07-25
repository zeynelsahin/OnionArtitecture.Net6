using App.Domain.Common;
using App.Domain.Entities;

namespace Add.Application.Interfaces.Repository;

public interface  IGenericRepositoryAsync<T> where T: BaseEntitiy
{
   Task<List<Entity1>> GetAllAsync();
   Task<T> GetByIdAsync(Guid id);
   Task<T> AddAsync(T entity);

}