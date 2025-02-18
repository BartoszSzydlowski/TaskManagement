﻿using AutoMapper;
using TaskManagement.Application.Mapping;
using TaskManagement.Application.ViewModels.User;
using TaskManagement.Domain.Enums;
using TaskManagement.Domain.Models;
using Entity = TaskManagement.Domain.Models;

namespace TaskManagement.Application.ViewModels.Task
{
    public class TaskViewModel : IMap
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Difficulty { get; set; }

        public TaskType TaskType { get; set; } = new();

        public UserViewModel? User { get; set; } = new();

        public Status Status { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Entity.Task, TaskViewModel>()
                .Include<ImplementationTask, ImplementationTaskViewModel>()
                .Include<MaintenanceTask, MaintenanceTaskViewModel>()
                .Include<DeploymentTask, DeploymentTaskViewModel>();
        }
    }
}
