using AutoMapper;
using TaskManagement.Application.Mapping;
using Entity = TaskManagement.Domain.Models;

namespace TaskManagement.Application.ViewModels.TaskViewModel
{
    public class TaskTypeViewModel : IMap
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Entity.TaskType, TaskTypeViewModel>();
        }
    }
}
