using MediatR;
using Microsoft.AspNetCore.Mvc;
using School.Core.Features.Student.Queries.Models;
using School.Domain.AppMetaData;

namespace School.Api.Controllers
{
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
        [HttpGet(Router.Student.List)]
        public async Task<IActionResult> GetStudentList()
        {
            var result = await _mediator.Send(new GetStudentListQuery());
            return Ok(result);
        }

        // get student by id
        [HttpGet(Router.Student.ById)]
        public async Task<IActionResult> GetStudentById(Guid id)
        {
            var result = await _mediator.Send(new GetStudentByIdQuery(id));
            return Ok(result);
        }
        #endregion  
    }
}
