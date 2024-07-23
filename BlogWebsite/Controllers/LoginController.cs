using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using BlogWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace BlogWebsite.Controllers
{

    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
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
            if (ModelState.IsValid)
            {
                var dataValue = await _context.writers.FirstOrDefaultAsync(x => x.WriterMail == writer.WriterMail
                && x.WriterPassword == writer.WriterPassword);
                if (dataValue != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, writer.WriterMail ?? "")

                        // claims.Add(new Claim(ClaimTypes.NameIdentifier, dataValue.WriterId.ToString()));
                        // claims.Add(new Claim(ClaimTypes.Name, dataValue.WriterName ?? ""));
                        // claims.Add(new Claim(ClaimTypes.GivenName, dataValue.WriterName ?? ""));
                        // claims.Add(new Claim(ClaimTypes.UserData, dataValue.WriterImage ?? ""));

                    };


                    var userIdentity = new ClaimsIdentity(claims, "a");
                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Writer");

                    // if (dataValue.WriterMail == "info@ahmetkaya.com")
                    // {
                    //     claims.Add(new Claim(ClaimTypes.Role, "admin"));
                    // }

                    // var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    // var autProperties = new AuthenticationProperties { IsPersistent = true };
                    // await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    // await HttpContext.SignInAsync(
                    //     CookieAuthenticationDefaults.AuthenticationScheme,
                    //     new ClaimsPrincipal(claimsIdentity), autProperties
                    // );
                    // return RedirectToAction("Index", "Blog");
                }
                else
                {

                    ModelState.AddModelError("", "Kullanıcı adı veya parola hatalı");
                    // return View();

                }

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