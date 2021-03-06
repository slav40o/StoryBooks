namespace StoryBooks.Features.Domain.Interfaces;

public interface IBaseUser
{
    string Id { get; }

    string FirstName { get; }

    string LastName { get; }

    string Email { get; }
}