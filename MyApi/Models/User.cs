namespace MyApi.Models;

public class User
{
    public int Id { get; set; }                     // Primary key
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    // For demos only. In real apps, never store plain passwords.
    // Store a salted hash (e.g., using ASP.NET Identity or a crypto lib).
    public string? PasswordHash { get; set; }

    public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedUtc { get; set; }
}
