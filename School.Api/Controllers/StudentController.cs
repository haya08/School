using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Core.Features.Student.Queries.Models;

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Fields
        private readonly IMediator _mediator;
        #endregion

        #region Constructors
        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #endregion

        #region Functions
        [HttpGet("/students/list")]
        public async Task<IActionResult> GetStudentList()
        {
            var result = await _mediator.Send(new GetStudentListQuery());
            return Ok(result);
        }
        #endregion  
    }
}
