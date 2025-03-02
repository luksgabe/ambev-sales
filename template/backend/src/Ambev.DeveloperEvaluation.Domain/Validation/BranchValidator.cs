using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class BranchValidator : AbstractValidator<Branch>
    {

        public BranchValidator()
        {
            RuleFor(branch => branch.Name)
            .NotEmpty()
            .MaximumLength(100).WithMessage("Branch name cannot be longer than 100 characters.");
        }
    }
}
