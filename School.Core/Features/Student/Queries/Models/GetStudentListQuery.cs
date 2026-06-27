using MediatR;
using School.Core.Bases;
using School.Core.Features.Student.Queries.Results;

namespace School.Core.Features.Student.Queries.Models
{
    public class GetStudentListQuery : IRequest<Response<List<GetStudentListDto>>>
    {
        
    }
}
