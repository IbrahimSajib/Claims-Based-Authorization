using System.ComponentModel.DataAnnotations;

namespace Claims_Based_Authorization.Models.UserManagement
{
    public class UserVM
    {
        //public UserVM()
        //{
        //    Claims = new List<string>();
        //}

        public string Id { get; set; }

        //[Required]
        //public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //public IList<string> Claims { get; set; }
    }
}
