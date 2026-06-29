using AutoMapper;
using MediatR;
using School.Core.Bases;
using School.Core.Features.Student.Commands.Models;
using School.Domain.Entities;
using School.Service.Abstracts;

namespace School.Core.Features.Student.Commands.Handlers
{
    public class StudentCommandHandler : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public StudentCommandHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        #endregion

        #region Functions
        public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            // map between the request DTO & TbStudent
            var resultMapper = _mapper.Map<TbStudent>(request);
            var result = await _studentService.AddAsync(resultMapper);
            if (result == "Student already exists")
                return UnprocessableEntity<string>();

            return Created(result);
        }
        #endregion
    }
}
