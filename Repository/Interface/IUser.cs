using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Repository.Interface
{
    interface IUser
    {
        bool CreateUser(IUserModel userModel);
        bool UpdateUser(IUserModel userModel);

        IUserModel GetUser(int UserId);
        List<IUserModel> GetUsers();

        bool DeleteUser(int UserId);


    }
}
