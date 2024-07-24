using BlogWebsite.Models;
using FluentValidation;

namespace BlogWebsite.BusinessLayer.ValidationRules
{

    public class BlogValidator : AbstractValidator<Blog>
    {

        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Title name can not be empty!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog Content mail can not be empty!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Image can not be empty!");
            RuleFor(x => x.BlogTitle).MinimumLength(50).WithMessage("Enter at least 50 char please!");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Enter maximum 150 char please!");


        }

    }
}