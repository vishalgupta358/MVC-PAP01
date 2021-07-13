using WebApplication2.Repository.Class;

namespace WebApplication2.Repository
{
    public static class Factory
    {
        public static UserAPI GetUserInstance()
        {
            return new UserAPI();
        }
    }
}