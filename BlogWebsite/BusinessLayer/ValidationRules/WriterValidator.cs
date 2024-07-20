using BlogWebsite.Models;
using FluentValidation;

namespace BlogWebsite.BusinessLayer.ValidationRules
{

    public class WriterValidator : AbstractValidator<User>
    {

        public WriterValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Writer name can not be empty!");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Writer mail can not be empty!");
            RuleFor(x => x.UserPassword).NotEmpty().WithMessage("Password can not be empty!");
            RuleFor(x => x.UserName).MinimumLength(2).WithMessage("Enter at least 2 char please!");
            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("Enter maximum 50 char please!");


        }

    }
}