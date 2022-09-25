using Microsoft.AspNetCore.Identity;

namespace FoodLog.Models
{
    public class Account : IdentityUser
    {
        public string Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                base.Id = value;
            }
        }
        public string Name { get; set; }    
        public string Password { get; set; }
        public string Email { get; set; }   
        public bool RememberMe { get; set; }
        public string Username { get; set; }
    }
}
