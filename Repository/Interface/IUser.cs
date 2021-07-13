using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repository.Interface
{
    interface IUser
    {
        bool CreateUser(UserModel userModel);
        bool UpdateUser(UserModel userModel);

        UserModel GetUser(int UserId);
        List<UserModel> GetUsers();

        bool DeleteUser(int UserId);


    }
}
