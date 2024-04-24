using System.ComponentModel.DataAnnotations;

namespace GreetingApp.Models
{
    public class UserNameModel
    {
        [Display(Name = "Enter your name: ")]
        [Required(ErrorMessage="Please enter your name")]
        [RegularExpression("^[A-Z]([a-z]{2,})", 
            ErrorMessage ="Please enter a valid name")]

        public string UserName { get; set; }
        public UserNameModel()
        {
            UserName = "";
        }

        public UserNameModel(string userName)
        {
            UserName = userName;
        }
    }
}
