using System;

namespace Calabonga.Contracts
{
    public interface IApplicationUserCreated
    {
        /// <summary>
        /// Identifier
        /// </summary>
        Guid Id { get; set; }
        /// <summary>
        /// FirstName
        /// </summary>
        string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        string LastName { get; set; }
    }
}
