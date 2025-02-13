using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.ViewModels.Task;
using TaskManagement.Domain.Enums;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MaintenanceTasksController(ITaskService<MaintenanceTaskViewModel> service) : ControllerBase
    {
        private readonly ITaskService<MaintenanceTaskViewModel> _service = service;

        public int TaskTypeId { get; } = 2;

        [HttpGet]
        public async Task<ListResponse<MaintenanceTaskViewModel>> GetFilteredByTaskTypeAndSortedByDifficultyDesc([FromQuery] int pageNumber, Status? status, int pageSize = 10, int? userId = 0)
        {
            return await _service.GetFilteredByTaskTypeAndSortedByDifficultyDesc(pageNumber, pageSize, status, TaskTypeId, userId);
        }
    }
}
