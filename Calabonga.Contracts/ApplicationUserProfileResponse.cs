using System;

namespace Calabonga.Contracts
{
    public class ApplicationUserProfileResponse
    {
        public string FavoriteColor { get; set; }
        public Guid Id { get; set; }
        public string PetName { get; set; }
        public string Skills { get; set; }
    }
}