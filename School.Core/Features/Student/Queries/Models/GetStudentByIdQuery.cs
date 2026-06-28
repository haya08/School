using MediatR;
using School.Core.Bases;
using School.Core.Features.Student.Queries.Results;

namespace School.Core.Features.Student.Queries.Models
{
    public class GetStudentByIdQuery : IRequest<Response<GetStudentDto>>
    {
        public Guid Id { get; set; }

        public GetStudentByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
