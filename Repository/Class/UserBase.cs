using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication2.Models;
using WebApplication2.Repository.Interface;

namespace WebApplication2.Repository.Class
{
    public  class User:IUser
    {
            static List<IUserModel> _userModel = new List<IUserModel> {
            new UserModel
            {
                UserId=1,
                Department="Accounts",
                FirstName="Vishal",
                UserName   ="Vishalg"

            },
            new UserModel
            {
                UserId=2,
                Department="Accounts",
                FirstName="Arun",
                UserName   ="Arung"

            },
            new UserModel
            {
                UserId=3,
                Department="Security",
                FirstName="Arvind",
                UserName   ="Arvindk"

            }
        };
        public bool CreateUser(IUserModel userModel)
        {
            try
            {
                userModel.UserId = _userModel.Count + 1;
                _userModel.Add(userModel);
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool DeleteUser(int UserId)
        {
            try
            {
                _userModel.RemoveAll(x => x.UserId == UserId);
            }
            catch
            (Exception e)
            {
                return false;
            }
            return true;
        }

        public IUserModel GetUser(int UserId)
        {
            return (IUserModel)_userModel.Where(x => x.UserId == UserId);
        }

        public List<IUserModel> GetUsers()
        {
            return _userModel;
        }

        public bool UpdateUser(IUserModel userModel)
        {
            try
            {
                DeleteUser(userModel.UserId);
                CreateUser(userModel);
            }
            catch
            {
                return false;
            }
            return true;
        }

      
    }
}