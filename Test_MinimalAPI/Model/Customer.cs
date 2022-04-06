using System.Text.Json.Serialization;

namespace Test_MinimalAPI.Model;

public class Customer
{
    [JsonPropertyName("id")]
    public Guid Id { get; init; } = Guid.NewGuid();

    [JsonPropertyName("fullName")]
    public string FullName { get; init; } = default!;
}
