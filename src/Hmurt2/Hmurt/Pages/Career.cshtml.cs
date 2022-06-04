using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hmurt.Pages
{
    public class CareerModel : PageModel
    {
        private readonly ILogger<CareerModel> _logger;

        public CareerModel(ILogger<CareerModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}