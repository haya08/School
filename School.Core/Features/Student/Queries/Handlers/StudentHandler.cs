using AutoMapper;
using MediatR;
using School.Core.Bases;
using School.Core.Features.Student.Queries.Models;
using School.Core.Features.Student.Queries.Results;
using School.Domain.Entities;
using School.Service.Abstracts;

namespace School.Core.Features.Student.Queries.Handlers
{
    public class StudentHandler : ResponseHandler, IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public StudentHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        #endregion

        #region Functions
        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var result = await _studentService.GetStudentListAsync();
            // Mapping Student entities to GetStudentListResponse DTOs using auto mapper
            var resultMapper = _mapper.Map<List<GetStudentListResponse>>(result);
            return Success(resultMapper);
        }
        #endregion
    }
}
