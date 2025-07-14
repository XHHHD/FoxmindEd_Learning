using FoxmindEd_Learning.API.Data.Entities;

namespace FoxmindEd_Learning.API.Abstractions.Repositories;

public interface IExampleEntityRepository
{
    Task PostAsync(ExampleEntity entity);
    Task<List<ExampleEntity>> GetAllAsync();
}
