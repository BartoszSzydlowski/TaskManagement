using AutoMapper;
using TaskManagement.Application.Mapping;
using Entity = TaskManagement.Domain.Models;

namespace TaskManagement.Application.ViewModels.TaskViewModel
{
    public class MaintenanceTaskViewModel : TaskViewModel, IMap
    {
        public DateTime DueDate { get; set; }

        public string ServiceList { get; set; } = string.Empty;

        public string ServerList { get; set; } = string.Empty;

        public new void Mapping(Profile profile)
        {
            profile.CreateMap<Entity.MaintenanceTask, MaintenanceTaskViewModel>();
        }
    }
}