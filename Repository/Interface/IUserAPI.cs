using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repository.Interface
{
    interface IUserAPI:IUser
    {
        new Task<List<UserModel>> GetUsers();
    }
}
