using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Senai.Saep.Web.Razor.Contextos;
using Senai.Saep.Web.Razor.Dominios;

namespace Senai.Saep.Web.Razor.Controllers
{
    public class LoginController : Controller
    {
        private readonly LanHouseContext _context;

        public LoginController(LanHouseContext context)
        {
            _context = context;
        }

        

        // GET: Login/Create
        public IActionResult Create()
        {
            HttpContext.Session.Clear();
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,Senha")] Usuarios usuarios)
        {
            if (ModelState.IsValid)
            {
                var usuario = _context.Usuarios.FirstOrDefault(x => x.Email == usuarios.Email && x.Senha == usuarios.Senha);

                if(usuario == null)
                {
                    ViewBag.Erro = "Usuário inválido";
                    return View(usuarios);
                }

                HttpContext.Session.SetString("email", usuarios.Email);

                return RedirectToAction("Create", "RegistrosDefeitos");
            }

            return View(usuarios);
        }
    }
}
