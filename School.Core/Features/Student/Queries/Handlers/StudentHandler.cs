using MediatR;
using School.Core.Features.Student.Queries.Models;
using School.Domain.Entities;
using School.Service.Abstracts;

namespace School.Core.Features.Student.Queries.Handlers
{
    public class StudentHandler : IRequestHandler<GetStudentListQuery, List<TbStudent>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        #endregion

        #region Constructors
        public StudentHandler(IStudentService studentService)
        {
            _studentService = studentService;
        }
        #endregion

        #region Functions
        public async Task<List<TbStudent>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentListAsync();
        }
        #endregion
    }
}
