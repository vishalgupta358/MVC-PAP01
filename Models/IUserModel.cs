using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public interface IUserModel
    {
        int UserId { get; set; }
        string UserName { get; set; }
        string FirstName { get; set; }
        string Department { get; set; }
    }
}