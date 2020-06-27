using FluentValidation;
using Goblin.Ui_Base.Core.Models;

namespace Goblin.Ui_Base.Core.Validators
{
    public class CreateSampleModelValidator : AbstractValidator<CreateSampleModel>
    {
        public CreateSampleModelValidator()
        {
            RuleFor(x => x.SampleData)
                .NotEmpty()
                .WithMessage("Please Input Sample Data");
        }
    }
}