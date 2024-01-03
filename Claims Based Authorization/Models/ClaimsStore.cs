using System.Security.Claims;

namespace Claims_Based_Authorization.Models
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
    {
        new Claim("Role","Admin"),
        new Claim("Role","HR"),
        new Claim("Role","Developer"),

        new Claim("Gender","Male"),
        new Claim("Gender","Female"),

        new Claim("Country","Bangladesh"),
        new Claim("Country","Japan"),
        new Claim("Country","Australia"),
        new Claim("Country","Canada")
    };
    }
}
