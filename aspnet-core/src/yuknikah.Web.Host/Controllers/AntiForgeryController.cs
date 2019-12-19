using Microsoft.AspNetCore.Antiforgery;
using yuknikah.Controllers;

namespace yuknikah.Web.Host.Controllers
{
    public class AntiForgeryController : yuknikahControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
