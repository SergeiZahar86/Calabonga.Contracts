using System;

namespace Calabonga.Contracts
{
    public interface IApplicationUserProfileResponse
    {
        public Guid Id { get; set; }
        public string PetName { get; set; }
        public string Skills { get; set; }
        public string FavoriteColor { get; set; }
    }
}