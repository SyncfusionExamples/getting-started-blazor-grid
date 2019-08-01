using Microsoft.AspNetCore.Mvc;
using MyBlazorApp.Shared;
using System.Collections.Generic;

namespace MyBlazorApp.Server.Controllers
{
  [Route("api/[controller]")]
  public class UserDataController : Controller
  {
    private UserService _users;

    public UserDataController(UserService users)
    {
      _users = users;
    }

    [HttpGet("[action]")]
    public IEnumerable<UserInfo> AllUsers()
    {
      return _users.AllUsers();
    }

    [HttpGet("[action]/{id}")]
    public IActionResult SingleUser(int id)
    {
      var user = _users.SingleUser(id);
      return (user == null) ? (IActionResult)NotFound() : Json(user);
    }

    [HttpPost("[action]/{id}/{status}")]
    public IActionResult SetStatus([FromRoute] int id, [FromRoute] bool status)
    {
      var user = _users.SetStatus(id, status);
      return (user == null) ? (IActionResult)NotFound() : Json(user);
    }

    [HttpPost("[action]")]
    public UserInfo AddNew([FromBody] UserInfo newUser)
    {
      return _users.AddNew(newUser);
    }
  }
}