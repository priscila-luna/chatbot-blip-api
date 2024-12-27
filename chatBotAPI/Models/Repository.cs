using System.Text.Json.Serialization;

public class Repository
{
    [JsonPropertyName("full_name")]
    public string FullName { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("owner")]
    public Owner Owner { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
}

public class Owner
{
    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }
}
