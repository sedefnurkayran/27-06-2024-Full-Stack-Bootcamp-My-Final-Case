
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BlogWebsite.Controllers
{

    public class LoginController : Controller
    {
        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {

            // if (User.Identity!.IsAuthenticated)
            // {
            //     return RedirectToAction("Index", "About");
            // }
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer writer)
        {
            
           // Context c = new Context();
                var dataValue = await _context.writers.FirstOrDefaultAsync(x => x.WriterMail == writer.WriterMail
                && x.WriterPassword == writer.WriterPassword);
                if (dataValue != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, writer.WriterMail ?? "")

                    };


                    var userIdentity = new ClaimsIdentity(claims, "a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Writer");

                 
                }
              
            return View(writer);
        }
    }
}


//  //DataContext c = new DataContext();
//             var dataValue = _context.writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);

//             if (dataValue != null)
//             {
//                 //HttpContent.Session.SetString("username", user.UserMail);
//                 HttpContext.Session.SetString("username", writer.WriterMail ?? "");
//                 return RedirectToAction("Index", "Writer");
//             }
//             else
//             {
//                 return View();
//             }