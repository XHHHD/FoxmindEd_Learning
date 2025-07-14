using FoxmindEd_Learning.API.Abstractions.Repositories;
using FoxmindEd_Learning.API.Abstractions.Services;
using FoxmindEd_Learning.API.Data.Entities;

namespace FoxmindEd_Learning.API.Services;

public class ExampleEntityService(
    IExampleEntityRepository exampleEntityRepository) : IExampleEntityService
{
    private readonly IExampleEntityRepository _exampleEntityRepository = exampleEntityRepository;

    public async Task PostAsync(ExampleEntity entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
        }

        await _exampleEntityRepository.PostAsync(entity);
    }

    public async Task<List<ExampleEntity>> GetAllAsync()
    {
        var entities = await _exampleEntityRepository.GetAllAsync();

        return entities;
    }
}
