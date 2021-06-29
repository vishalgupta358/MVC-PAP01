using WebApplication2.Repository.Class;

namespace WebApplication2.Repository
{
    public static class Factory
    {
        public static User GetUserInstance() {
            return new User();
        }
    }
}