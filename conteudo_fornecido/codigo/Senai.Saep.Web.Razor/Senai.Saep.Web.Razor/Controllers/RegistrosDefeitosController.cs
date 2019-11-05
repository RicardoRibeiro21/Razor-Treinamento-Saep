using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Senai.Saep.Web.Razor.Contextos;
using Senai.Saep.Web.Razor.Dominios;

namespace Senai.Saep.Web.Razor.Controllers
{
    public class RegistrosDefeitosController : Controller
    {
        private readonly LanHouseContext _context;

        public RegistrosDefeitosController(LanHouseContext context)
        {
            _context = context;
        }

        // GET: RegistrosDefeitos
        public async Task<IActionResult> Index()
        {
            if(HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            var lanHouseContext = _context.RegistrosDefeitos.Include(r => r.TipoDefeito).Include(r => r.TipoEquipamento);
            return View(await lanHouseContext.ToListAsync());
        }

        // GET: RegistrosDefeitos/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("email") == null)
            {
                return RedirectToAction("Create", "Login");
            }

            ViewData["TipoDefeitoId"] = new SelectList(_context.TiposDefeitos, "Id", "Nome");
            ViewData["TipoEquipamentoId"] = new SelectList(_context.TiposEquipamentos, "Id", "Nome");
            return View();
        }

        // POST: RegistrosDefeitos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataDefeito,TipoEquipamentoId,TipoDefeitoId,Observacao")] RegistrosDefeitos registrosDefeitos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registrosDefeitos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoDefeitoId"] = new SelectList(_context.TiposDefeitos, "Id", "Nome", registrosDefeitos.TipoDefeitoId);
            ViewData["TipoEquipamentoId"] = new SelectList(_context.TiposEquipamentos, "Id", "Nome", registrosDefeitos.TipoEquipamentoId);
            return View(registrosDefeitos);
        }
    }
}
