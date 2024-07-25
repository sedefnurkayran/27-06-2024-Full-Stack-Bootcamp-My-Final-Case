using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{

    public class WriterValidator : AbstractValidator<Writer>
    {

        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Writer name can not be empty!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Writer mail can not be empty!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password can not be empty!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Enter at least 2 char please!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Enter maximum 50 char please!");


        }

    }
}