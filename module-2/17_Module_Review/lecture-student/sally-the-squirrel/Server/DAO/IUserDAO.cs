using SallyServer.Models;
using System.Collections.Generic;

namespace SallyServer.DAO
{
    public interface IUserDAO
    {
        User GetUser(string username);
        User AddUser(string username, string password);
        List<User> GetUsers();
    }
}
