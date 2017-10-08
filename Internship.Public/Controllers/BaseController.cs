using Internship.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Internship.Public.Controllers
{
    public class BaseController: Controller
    {
        public BaseController()
        {
        }

        public User GetLoggedInUser()
        {
            return GetSession<User>("LoggedInUser");
        }

        public void SetLoggedInUser(User user)
        {
            SetSession("LoggedInUser", user);
        }

        public void SetSession(string key, object o)
        {
            var str = JsonConvert.SerializeObject(o);
            HttpContext.Session.SetString(key, str);
        }

        public T GetSession<T>(string key)
        {
            var value = HttpContext.Session.GetString(key);
            if (value != null)
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            return default(T);
        }

    }
}
