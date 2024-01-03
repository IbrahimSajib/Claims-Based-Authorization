namespace Claims_Based_Authorization.Models.UserManagement
{
    public class UserClaim
    {
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public bool IsSelected { get; set; }
    }
}
