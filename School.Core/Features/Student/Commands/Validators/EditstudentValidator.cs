using FluentValidation;
using School.Core.Features.Student.Commands.Models;
using School.Service.Abstracts;

namespace School.Core.Features.Student.Commands.Validators
{
    public class EditStudentValidator : AbstractValidator<EditStudentCommand>
    {
        #region Fields
        private readonly IStudentService _studentService;
        #endregion

        #region Constructors
        public EditStudentValidator(IStudentService studentService)
        {
            _studentService = studentService;
            ApplyValidationRules();
            ApplyCustomValidationRules();
        }
        #endregion

        #region Functions
        public void ApplyValidationRules()
        {
            RuleFor(s => s.FirstName)
                .MaximumLength(50);

            RuleFor(s => s.LastName)
                .MaximumLength(50);

            RuleFor(s => s.Address)
                .MaximumLength(50);

            RuleFor(s => s.Email)
                .MaximumLength(50)
                .EmailAddress();

            RuleFor(s => s.PhoneNumber)
                .Length(11);
        }

        public void ApplyCustomValidationRules()
        {
            RuleFor(r => r.Email)
                .MustAsync(async (Key, CancellationToken) => await _studentService.IsEmailExists(Key))
                .WithMessage("Email is not exist!");
        }
        #endregion
    }
}
