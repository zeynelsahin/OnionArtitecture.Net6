using Add.Application.Interfaces.Repository;
using App.Domain.Entities;
using App.Persistence.Context;

namespace App.Persistence.Repositories;

public class Entity1Repository: GenericRepositoryAsync<Entity1>,IEntity1Repository
{
    public Entity1Repository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}