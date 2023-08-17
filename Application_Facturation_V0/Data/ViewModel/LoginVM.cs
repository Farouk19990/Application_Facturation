using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Application_Facturation_V0.Data.ViewModel
{
    public class LoginVM
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }  
    }
}
