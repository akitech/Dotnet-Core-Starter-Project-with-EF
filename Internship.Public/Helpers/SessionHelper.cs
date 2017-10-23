using Internship.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace Internship.Public
{
    public static class SessionHelper
    {

        public static void SetSession(this ISession session, string key, object o)
        {
            var str = JsonConvert.SerializeObject(o);
            session.SetString(key, str);
        }

        public static T GetSession<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            if (value != null)
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            return default(T);
        }

        public static User GetLoggedInUser(this ISession session)
        {
            return session.GetSession<User>("LoggedInUser");
        }

        public static void SetLoggedInUser(this ISession session, User user)
        {
            session.SetSession("LoggedInUser", user);
        }

    }
}
