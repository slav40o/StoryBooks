﻿namespace StoryBooks.Features.Authors.Domain.Exceptions;

using StoryBooks.Features.Domain.Exceptions;

internal class TagNotFoundException : BaseDomainException
{
    public TagNotFoundException() { }

    public TagNotFoundException(string error) => this.Error = error;
}