using FluentValidation;
using School.Core.Features.Student.Commands.Models;

namespace School.Core.Features.Student.Commands.Validators
{
    public class AddStudentValidator : AbstractValidator<AddStudentCommand>
    {
        #region Fields
        #endregion

        #region Constructors
        public AddStudentValidator()
        {
            ApplyValidationRules();
        }
        #endregion

        #region Functions
        public void ApplyValidationRules()
        {
            RuleFor(r => r.FirstName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);

            RuleFor(r => r.LastName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);

            RuleFor(r => r.Address)
                .MaximumLength(50);

            RuleFor(r => r.Email)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50)
                .EmailAddress();

            RuleFor(r => r.PhoneNumber)
                .NotEmpty()
                .NotNull()
                .Length(11);
        }
        #endregion
    }
}
