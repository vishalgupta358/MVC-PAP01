using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class UserModel: IUserModel
    {
        [DisplayName("User Id")]
        
        public int UserId { get; set; }
        [DisplayName("User Name")]
        
        
        [MinLength(6)]
        [Required(ErrorMessage = "Please Give User Name")]
        public string UserName { get; set; }
        [DisplayName("Display Name")]
        [Required(ErrorMessage = "Please Give First Name")]
        public string FirstName { get; set; }
        [DisplayName("Department")]
        public string Department { get; set; }
    }
}