using Microsoft.AspNetCore.Mvc.Filters;

namespace MyApplication.Web
{
    // Written using reference from:
    // https://docs.microsoft.com/en-us/dotnet/standard/attributes/writing-custom-attributes

    public class Authorize: ActionFilterAttribute
    {
        // private UserType requiredUserType;
        public Authorize()
        {
        }
        

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            /*
            // Getting current session of the filter context
            var session = filterContext.HttpContext.Session;

            // Get logged in user
            var loggedInUser = session.GetLoggedInUser();

            // Check if Logged in
            // 1. Needs to be logged in no matter what
            // 2. If logged in:
            // 2a. Either requiredUserType is not set, i.e. 0
            // 2b. Or, they must be equal


            if (loggedInUser == null)
            {
                var controller = (Controller)filterContext.Controller;
                filterContext.Result = controller.RedirectToAction("Login", "User");
                return;
            }


            if (requiredUserType > 0 && loggedInUser.UserType != requiredUserType)
            {
                // Solution from:
                // https://stackoverflow.com/questions/5453338/redirect-from-action-filter-attribute

                var controller = (Controller)filterContext.Controller;
                filterContext.Result = controller.RedirectToAction("UnauthorizedUser", "Home");
                return;
            }
            */
        }

    }
}
