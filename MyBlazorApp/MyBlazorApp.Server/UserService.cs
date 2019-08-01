using MyBlazorApp.Shared;
using System.Collections.Generic;
using System.Linq;

namespace MyBlazorApp.Server
{
  public class UserService
  {
    private List<UserInfo> _users = new List<UserInfo>(){
      new UserInfo() { Id = 1, Name = "Shawty", Email = "shawty.d.ds@googlemail.com", Type = "ADMIN", IsAvailable = true},
      new UserInfo() { Id = 2, Name = "Kirk", Email = "kirk@theenterprise.com", Type = "CAPTIN", IsAvailable = true},
      new UserInfo() { Id = 3, Name = "Monty", Email = "montymole@oceansoftware.com", Type = "MOLE", IsAvailable = false},
      new UserInfo() { Id = 4, Name = "Repton", Email = "repton@superior.com", Type = "LIZARD", IsAvailable = false}
    };

    public IEnumerable<UserInfo> AllUsers()
    {
      return _users;
    }

    public UserInfo SingleUser(int id)
    {
      return _users.FirstOrDefault(u => u.Id == id);
    }

    public UserInfo SetStatus(int id, bool status)
    {
      var user = _users.FirstOrDefault(u => u.Id == id);
      if (user == null)
      {
        return null;
      }

      user.IsAvailable = status;
      return user;
    }

    public UserInfo AddNew(UserInfo newUser)
    {
      int maxInt = _users.Select(u => u.Id).Max();
      newUser.Id = maxInt + 1;
      _users.Add(newUser);
      return newUser;
    }

  }
}