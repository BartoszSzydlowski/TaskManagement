using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.ViewModels.TaskViewModel;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TasksController(ITaskService service) : ControllerBase
    {
        private readonly ITaskService _service = service;

        [HttpGet]
        public async Task<ListResponse<TaskViewModel>> GetSortedByDifficultyDesc([FromQuery] int? userId)
        {
            return await _service.GetSortedByDifficultyDesc(userId);
        }
    }
}