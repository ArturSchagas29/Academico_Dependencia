using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Academico_Dependencia.Data;
using Academico_Dependencia.Models;

namespace Academico_Dependencia.Controllers
{
    public class InstituicaosController : Controller
    {
        private readonly AcademicoContext _context;

        public InstituicaosController(AcademicoContext context)
        {
            _context = context;
        }

        // GET: Instituicaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Instituicoes.ToListAsync());
        }

        // GET: Instituicaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituicao = await _context.Instituicoes
                .FirstOrDefaultAsync(m => m.InstituicaoID == id);
            if (instituicao == null)
            {
                return NotFound();
            }

            return View(instituicao);
        }

        // GET: Instituicaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Instituicaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstituicaoID,Nome,Endereco")] Instituicao instituicao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(instituicao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(instituicao);
        }

        // GET: Instituicaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituicao = await _context.Instituicoes.FindAsync(id);
            if (instituicao == null)
            {
                return NotFound();
            }
            return View(instituicao);
        }

        // POST: Instituicaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InstituicaoID,Nome,Endereco")] Instituicao instituicao)
        {
            if (id != instituicao.InstituicaoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(instituicao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstituicaoExists(instituicao.InstituicaoID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(instituicao);
        }

        // GET: Instituicaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instituicao = await _context.Instituicoes
                .FirstOrDefaultAsync(m => m.InstituicaoID == id);
            if (instituicao == null)
            {
                return NotFound();
            }

            return View(instituicao);
        }

        // POST: Instituicaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var instituicao = await _context.Instituicoes.FindAsync(id);
            if (instituicao != null)
            {
                _context.Instituicoes.Remove(instituicao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstituicaoExists(int id)
        {
            return _context.Instituicoes.Any(e => e.InstituicaoID == id);
        }
    }
}
