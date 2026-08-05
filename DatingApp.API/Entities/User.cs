namespace DatingApp.API.Entities;

public class User
{
    public string Id { get; set; } = Guid.CreateVersion7().ToString();
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
}
