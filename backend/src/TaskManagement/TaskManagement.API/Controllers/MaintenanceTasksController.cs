using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.ViewModels.TaskViewModel;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MaintenanceTasksController(ITaskService<MaintenanceTaskViewModel> service)
    {
        private readonly ITaskService<MaintenanceTaskViewModel> _service = service;

        public int TaskTypeId { get; } = 2;

        [HttpGet]
        public async Task<PagedResponse<MaintenanceTaskViewModel>> GetFilteredByTaskTypeAndSortedByDifficultyDesc([FromQuery] int pageNumber, int pageSize = 10, int? userId = 0)
        {
            return await _service.GetFilteredByTaskTypeAndSortedByDifficultyDesc(pageNumber, pageSize, TaskTypeId, userId);
        }
    }
}