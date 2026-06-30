using Microsoft.AspNetCore.Mvc;
using School.Api.Bases;
using School.Core.Features.Student.Commands.Models;
using School.Core.Features.Student.Queries.Models;
using School.Domain.AppMetaData;

namespace School.Api.Controllers
{
    [ApiController]
    public class StudentController : AppControllerBase
    {
        [HttpGet(Router.Student.List)]
        public async Task<IActionResult> GetStudentList()
        {
            var result = await Mediator.Send(new GetStudentListQuery());
            return NewResult(result);
        }

        [HttpGet(Router.Student.ById)]
        public async Task<IActionResult> GetStudentById(Guid id)
        {
            var result = await Mediator.Send(new GetStudentByIdQuery(id));
            return NewResult(result);
        }

        [HttpPost(Router.Student.Add)]
        public async Task<IActionResult> AddStudent([FromBody] AddStudentCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpPut(Router.Student.Edit)]
        public async Task<IActionResult> EditStudent([FromBody] EditStudentCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }
    }
}
