using AutoMapper;
using TaskManagement.Application.ViewModels.User;
using TaskManagement.Domain.Enums;
using TaskManagement.Domain.Models;

using Entity = TaskManagement.Domain.Models;

namespace TaskManagement.Application.ViewModels.TaskViewModel
{
    public class TaskViewModel
    {
        public int Id { get; set; }

        public string Content { get; set; } = string.Empty;

        public int Difficulty { get; set; }

        public TaskType TaskType { get; set; } = new();

        public UserViewModel? User { get; set; } = new();

        public Status Status { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Entity.Task, TaskViewModel>();
        }
    }
}