using FoxmindEd_Learning.WPF.Entities;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace FoxmindEd_Learning.WPF.Clients;

public class APIClient
{
    public const string POST_URL = "https://localhost:7288/example";
    public const string GETALL_URL = "https://localhost:7288/example";

    public async Task PostAsync(ExampleEntity entity)
    {
        using var httpClient = new HttpClient();
        var jsonContent = new StringContent(JsonSerializer.Serialize(entity), Encoding.UTF8, "application/json");
        var response = await httpClient.PostAsync(POST_URL, jsonContent);
        response.EnsureSuccessStatusCode();
    }

    public async Task<List<ExampleEntity>> GetAllAsync()
    {
        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(GETALL_URL);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<List<ExampleEntity>>() ?? [];
    }
}