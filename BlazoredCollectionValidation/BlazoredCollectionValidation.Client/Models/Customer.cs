namespace BlazoredCollectionValidation.Client.Models;

public class Customer
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public List<Email> Emails { get; set; } = new();
}

public class Email
{
    public Email()
    {
        //
    }

    public string Value { get; set; } = string.Empty;
}