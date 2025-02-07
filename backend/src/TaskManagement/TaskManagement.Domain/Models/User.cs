namespace TaskManagement.Domain.Models
{
    public class User : BaseEntity
    {
        public string Login { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public UserType UserType { get; set; } = new();
    }
}
