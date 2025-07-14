namespace FoxmindEd_Learning.API.Data.Entities;

public class ExampleEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Place { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public DateTime Time { get; set; } = DateTime.UtcNow;
    public string Description { get; set; } = string.Empty;
    public string AdditionalInfo { get; set; } = string.Empty;
    public string ImageURL { get; set; } = string.Empty;
}
