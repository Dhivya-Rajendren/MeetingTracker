using Microsoft.AspNetCore.Mvc;
using MeetingTracker.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace MeetingTracker.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        IMeetingRepoistory _repo = new MeetingRepoistory();
        public IActionResult Login( string returnURL)
        {
            

            return View(new User() {ReturnURL=returnURL });
        }

        [HttpPost]
        public IActionResult Login(User userModel)
        {

            var user = _repo.GetUser(userModel.UserName, userModel.Password);
                if (user==null)
            {
                return Unauthorized();
            }

                //Aadhar  card claiming name, dob , address
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserName),
                new Claim(ClaimTypes.Name,user.FirstName),
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal= new ClaimsPrincipal(identity);
            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return LocalRedirect(userModel.ReturnURL);
        }
    }
}
