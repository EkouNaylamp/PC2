using Microsoft.AspNetCore.Mvc;
using PC2.Data;
using PC2.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PC2.Controllers
{
    public class CuentaBancariaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CuentaBancariaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CuentaBancaria
        public IActionResult Index()
        {
            var cuentas = _context.CuentasBancarias.ToList();
            return View(cuentas);
        }

        // GET: CuentaBancaria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CuentaBancaria/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CuentaBancaria cuentaBancaria)
        {
            // Aquí no se realiza ninguna validación
            _context.Add(cuentaBancaria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
