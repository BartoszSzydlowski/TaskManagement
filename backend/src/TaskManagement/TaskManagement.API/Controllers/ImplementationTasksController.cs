using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.ViewModels.Task;
using TaskManagement.Domain.Enums;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImplementationTasksController(ITaskService<ImplementationTaskViewModel> service) : ControllerBase
    {
        private readonly ITaskService<ImplementationTaskViewModel> _service = service;

        public int TaskTypeId { get; } = 3;

        [HttpGet]
        public async Task<ListResponse<ImplementationTaskViewModel>> GetFilteredByTaskTypeAndSortedByDifficultyDesc([FromQuery]Status? status, int? userId = 0)
        {
            return await _service.GetFilteredByTaskTypeAndSortedByDifficultyDesc(status, TaskTypeId, userId);
        }
    }
}
