using BlazoredCollectionValidation.Client.Models;
using FluentValidation;

namespace BlazoredCollectionValidation.Client.Validators;
public class CustomerValidator : AbstractValidator<Customer>
{
    public CustomerValidator()
    {
        //RuleFor(c => c.FirstName)
        //        .NotEmpty();
        //RuleFor(c => c.LastName)
        //    .NotEmpty();

        RuleSet(nameof(Customer), () =>
        {
            RuleFor(c => c.FirstName)
                .NotEmpty();
            RuleFor(c => c.LastName)
                .NotEmpty();
        });

        //RuleForEach(c => c.Emails)
        //        .SetValidator(new EmailValidator());

        // Rule only in parent validator did not work
        RuleSet(nameof(Customer.Emails), () =>
        {
            RuleForEach(c => c.Emails)
                .SetValidator(new EmailValidator());
        });
    }
}
