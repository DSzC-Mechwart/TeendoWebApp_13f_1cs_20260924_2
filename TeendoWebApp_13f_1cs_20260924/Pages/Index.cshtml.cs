using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeendoWebApp_13f_1cs_20260924.Data;
using TeendoWebApp_13f_1cs_20260924.Models;

namespace TeendoWebApp_13f_1cs_20260924.Pages
{
    public class IndexModel : PageModel
    {
        private readonly TeendoDbContext _context;
        public IndexModel(TeendoDbContext context)
        {
            _context = context;
        }
        public IList<Teendo> Teendok { get; set; }
        public void OnGet()
        {
            Teendok = _context.Teendok.ToList();
        }
    }
}
