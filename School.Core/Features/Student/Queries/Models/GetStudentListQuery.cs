using MediatR;
using School.Domain.Entities;

namespace School.Core.Features.Student.Queries.Models
{
    public class GetStudentListQuery : IRequest<List<TbStudent>>
    {
        
    }
}
