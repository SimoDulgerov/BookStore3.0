using BookStore.Models.Request;
using FluentValidation;

namespace BookStore.Validators
{
    public class BookValidator : AbstractValidator<GetBooksByAuthorRequest>
    {
        public BookValidator()
        {
            RuleFor(GetBooksByAuthorRequest => GetBooksByAuthorRequest.AuthorId)
                .NotNull()
                .NotEmpty()
                .LessThan(1)
                .GreaterThan(10);
            RuleFor(GetBooksByAuthorRequest => GetBooksByAuthorRequest.AfterDate)
                .NotEmpty();
        }
    }
}
