using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        //AllowAnonymous proje bazlı yapmış olduğumuz authorazion kisitlamasında muaf tutmak için kullanıldı.
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Writer writer)
        {
            //LoginValidatior wv = new LoginValidatior();
            //ValidationResult result = wv.Validate(writer);
            //if (result.IsValid)
            //{

            //    return RedirectToAction("Index", "Blog");
            //}
            //else
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}

            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
            if (datavalue != null)
            {
                //HttpContext.Session.SetString("username", writer.WriterMail);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, writer.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index","Dashboard");

            }
            else
            {
                return View();
            }


        }
    }
}
