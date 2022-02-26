﻿namespace StoryBooks.Features.Common.Application
{
    public partial class ApplicationSettings
    {
        public string Version { get; protected set; } = default!;

        public ApplicationRoles Roles { get; protected set; } = default!;
    }

    public class ApplicationRoles
    {
        public string Admin { get; private set; } = default!;

        public string Author { get; private set; } = default!;

        public string Moderator { get; private set; } = default!;

        public string User { get; private set; } = default!;
    }
}
