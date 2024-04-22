
using Microsoft.Extensions.Configuration.UserSecrets;

namespace MeetingApp.Models;

public static class Repository
{
    private static List<UserInfo> _users= new();

    static Repository()
    {
        _users.Add(new UserInfo() { Id=1, Name = "İdris", Email="info@idris.com", Phone="5467649", WillAttend=true});
        _users.Add(new UserInfo() { Id=2,Name = "Ahmet", Email="info@ahmet.com", Phone="798756", WillAttend=false});
        _users.Add(new UserInfo() { Id=3,Name = "Canan", Email="info@canan.com", Phone="546598877649", WillAttend=true});
    }

    public static List<UserInfo> Users {
        get 
        {return _users;}
    }
    public static void CreateUser (UserInfo user)
    {
        user.Id= Users.Count +1;
        _users.Add(user);
    }
    public static UserInfo? GetById (int id)
    {
          return _users.FirstOrDefault(user => user.Id == id);
    }
}