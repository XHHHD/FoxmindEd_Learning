using FoxmindEd_Learning.API.Abstractions.Repositories;
using FoxmindEd_Learning.API.Data.Entities;
using FoxmindEd_Learning.API.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace FoxmindEd_Learning.API.Repositories;

public class ExampleEntityRepository(
    FE_DbContext dbContext) : IExampleEntityRepository
{
    private readonly FE_DbContext _dbContext = dbContext;

    public async Task PostAsync(ExampleEntity entity)
    {
        _dbContext.ExampleEntities.Add(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<ExampleEntity>> GetAllAsync()
        => await _dbContext.ExampleEntities.ToListAsync();
}
