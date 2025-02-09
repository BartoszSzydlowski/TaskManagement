using AutoMapper;
using TaskManagement.Application.Mapping;
using Entity = TaskManagement.Domain.Models;

namespace TaskManagement.Application.ViewModels.User
{
    public class UserViewModel : IMap
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public UserTypeViewModel UserType { get; set; } = new();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Entity.User, UserViewModel>();
        }
    }
}
