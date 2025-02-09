using AutoMapper;
using TaskManagement.Application.Mapping;
using Entity = TaskManagement.Domain.Models;

namespace TaskManagement.Application.ViewModels.TaskViewModel
{
    public class ImplementationTaskViewModel : TaskViewModel, IMap
    {
        public string TaskContent { get; set; } = string.Empty;

        public new void Mapping(Profile profile)
        {
            profile.CreateMap<Entity.ImplementationTask, ImplementationTaskViewModel>();
        }
    }
}
