using AutoMapper;
using TaskManagement.Application.Mapping;
using Entity = TaskManagement.Domain.Models;

namespace TaskManagement.Application.ViewModels.User
{
    public class UserTypeViewModel : IMap
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Entity.UserType, UserTypeViewModel>();
        }
    }
}