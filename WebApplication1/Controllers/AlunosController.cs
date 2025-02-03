using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlunosController : Controller
    {
        public readonly SchoolContext _dbSchoolContext;
        public AlunosController(SchoolContext schoolContext)
        {
            _dbSchoolContext = schoolContext;
        }
        // GET: AlunosController1
        public async Task<IActionResult> Index()
        {
            var listar = await _dbSchoolContext.Alunos.ToListAsync();
            return View(listar);
        }

        // GET: AlunosController1/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var detalhes = await _dbSchoolContext.Alunos.Include(x => x.Inscricao).FirstOrDefaultAsync(x => x.Id == id);
            if(detalhes == null)return NotFound();
            return View(detalhes);
        }

        // GET: AlunosController1/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: AlunosController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Alunos aluno)
        {
            _dbSchoolContext.Alunos.Add(aluno);
            await _dbSchoolContext.SaveChangesAsync();
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(aluno);
            }
        }

        // GET: AlunosController1/Edit/5
        public ActionResult Edit(int id)
        {
            var editar = Details(id);
            if(editar  == null)
            {
                return BadRequest();
            }
            id = editar.Id;
            return View(editar);
        }

        // POST: AlunosController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AlunosController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AlunosController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
