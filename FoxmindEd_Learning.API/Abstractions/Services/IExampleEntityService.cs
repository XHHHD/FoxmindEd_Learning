using FoxmindEd_Learning.API.Data.Entities;

namespace FoxmindEd_Learning.API.Abstractions.Services;

public interface IExampleEntityService
{
    Task PostAsync(ExampleEntity entity);
    Task<List<ExampleEntity>> GetAllAsync();
}
