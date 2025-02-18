﻿namespace TaskManagement.Domain.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public UserType UserType { get; set; } = new();
    }
}
