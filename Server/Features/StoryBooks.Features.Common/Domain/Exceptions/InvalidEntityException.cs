namespace StoryBooks.Features.Common.Domain.Exceptions
{
    public class InvalidEntityException : BaseDomainException
    {
        public InvalidEntityException()
        { }

        public InvalidEntityException(string error) => this.Error = error;
    }
}
