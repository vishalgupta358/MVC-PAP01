using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using WebApplication2.Models;
using WebApplication2.Repository.Interface;

namespace WebApplication2.Repository.Class
{
    public class UserAPI : IUser
    {
        string Baseurl = "http://localhost:53257/";
        public bool CreateUser(UserModel userModel)
        {


            var client = new HttpClient();

            client.BaseAddress = new Uri(Baseurl);

            //HTTP POST
            var postTask = client.PostAsJsonAsync("UserApi", userModel);
            postTask.Wait();

            var result = postTask.Result;

            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return true;
            }
            return false;




        }

        public bool DeleteUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUser(int UserId)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetUsers()
        {
            List<UserModel> UserInfo = new List<UserModel>();
            try
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(Baseurl);

                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var responsetask = client.GetAsync("UserAPI");

                    responsetask.Wait();

                    HttpResponseMessage Res = responsetask.Result;

                    if (Res.IsSuccessStatusCode)
                    {

                        var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

                        var UserResponse = Res.Content.ReadAsStringAsync().Result;

                        UserInfo = JsonConvert.DeserializeObject<List<UserModel>>(UserResponse, settings);
                    }
                }
            }
            catch (Exception e)
            {

            }//returning the employee list to view
            return UserInfo;
        }

        public bool UpdateUser(UserModel userModel)
        {
            throw new NotImplementedException();
        }



    }
}