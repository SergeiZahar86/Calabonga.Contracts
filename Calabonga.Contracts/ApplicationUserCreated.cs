using System;

namespace Calabonga.Contracts
{
    public class ApplicationUserCreated : IApplicationUserCreated
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
