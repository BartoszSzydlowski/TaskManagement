using AutoMapper;
using TaskManagement.Application.Mapping;
using Entity = TaskManagement.Domain.Models;

namespace TaskManagement.Application.ViewModels.TaskViewModel
{
    public class DeploymentTaskViewModel : TaskViewModel, IMap
    {
        public string Scope { get; set; } = string.Empty;

        public new void Mapping(Profile profile)
        {
            profile.CreateMap<Entity.DeploymentTask, DeploymentTaskViewModel>();
        }
    }
}
