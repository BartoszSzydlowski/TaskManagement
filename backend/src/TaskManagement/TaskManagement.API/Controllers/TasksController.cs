using Microsoft.AspNetCore.Mvc;
using TaskManagement.Application.Common.Responses;
using TaskManagement.Application.Interfaces;
using TaskManagement.Application.Requests;
using TaskManagement.Application.ViewModels.TaskViewModel;

namespace TaskManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TasksController(ITaskService<DeploymentTaskViewModel> service) : ControllerBase
    {
        private readonly ITaskService<DeploymentTaskViewModel> _service = service;

        [HttpPost]
        public async Task<BaseResponse> AddTaskToUser([FromBody] AddTaskToUserRequest request)
        {
            return await _service.AddTaskToUser(request);
        }
    }
}
