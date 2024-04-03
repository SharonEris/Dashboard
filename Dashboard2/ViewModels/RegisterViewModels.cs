using Microsoft.AspNetCore.Identity;

namespace Dashboard2.ViewModels
{
    public class RegisterViewModels : IdentityUser
    {

        public string Userame { get; set; }
    }

}
