using BlazoredCollectionValidation.Client.Models;
using FluentValidation;

namespace BlazoredCollectionValidation.Client.Validators;
public class EmailValidator : AbstractValidator<Email>
{
    public EmailValidator()
    {
        // Rule only in validator did not work
        RuleSet(nameof(Customer.Emails), () =>
        {
            RuleFor(e => e.Value)
                .NotEmpty()
                .Matches(@"^[^\W_]+\w*(?:[.-]\w*)*[^\W_]+@[^\W_]+(?:[.-]?\w*[^\W_]+)*(?:\.[^\W_]{2,})$");
        });
    }
}
