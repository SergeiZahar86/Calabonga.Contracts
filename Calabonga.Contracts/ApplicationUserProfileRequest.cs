using System;

namespace Calabonga.Contracts
{
    public class ApplicationUserProfileRequest : IApplicationUserProfileRequest
    {
        public Guid Id { get; set; }
    }
}