﻿using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.ViewModels.TaskViewModel;
using TaskManagement.Domain.Enums;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DeploymentTasksController(ITaskService<DeploymentTaskViewModel> service) : ControllerBase
    {
        private readonly ITaskService<DeploymentTaskViewModel> _service = service;

        public int TaskTypeId { get; } = 1;

        [HttpGet]
        public async Task<PagedResponse<DeploymentTaskViewModel>> GetFilteredByTaskTypeAndSortedByDifficultyDesc([FromQuery] int pageNumber, Status status, int pageSize = 10, int? userId = 0)
        {
            return await _service.GetFilteredByTaskTypeAndSortedByDifficultyDesc(pageNumber, pageSize, status, TaskTypeId, userId);
        }
    }
}
