using Microsoft.AspNetCore.Identity;

namespace AutopartsEntity.Identity.Entities
{
    public class AutopartsUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public short? EmailConfirm {  get; set; }
    }
}