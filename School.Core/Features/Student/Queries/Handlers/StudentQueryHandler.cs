using AutoMapper;
using MediatR;
using School.Core.Bases;
using School.Core.Features.Student.Queries.Models;
using School.Core.Features.Student.Queries.Results;
using School.Service.Abstracts;

namespace School.Core.Features.Student.Queries.Handlers
{
    public class StudentQueryHandler : ResponseHandler, IRequestHandler<GetStudentListQuery, Response<List<GetStudentDto>>>
                                                      , IRequestHandler<GetStudentByIdQuery, Response<GetStudentDto>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public StudentQueryHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        #endregion

        #region Functions
        public async Task<Response<List<GetStudentDto>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var result = await _studentService.GetStudentListAsync();
            // Mapping Student entities to GetStudentListResponse DTOs using auto mapper
            var resultMapper = _mapper.Map<List<GetStudentDto>>(result);
            return Success(resultMapper);
        }

        public async Task<Response<GetStudentDto>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _studentService.GetStudentByIdAsync(request.Id);
            if(result == null)
                return NotFound<GetStudentDto>();

            var resultMapper = _mapper.Map<GetStudentDto>(result);
            return Success(resultMapper);
        }
        #endregion
    }
}
