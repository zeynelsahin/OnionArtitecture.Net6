using Add.Application.Interfaces.Repository;
using App.Domain.Common;
using App.Domain.Entities;
using App.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Repositories;

public class GenericRepositoryAsync<T>: IGenericRepositoryAsync<T> where T : BaseEntitiy
{
    private readonly ApplicationDbContext _dbContext;

    public GenericRepositoryAsync( ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Entity1>> GetAllAsync()
    {
        var entity1s = await _dbContext.Set<Entity1>().ToListAsync();
        return entity1s;
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }
}