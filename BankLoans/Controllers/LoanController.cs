using Microsoft.AspNetCore.Mvc;

namespace BankLoans.Controllers
{
    public class LoanController : Controller
    {
        public IActionResult ApplyForLoans()
        {
            return View();
        }
    }
}
