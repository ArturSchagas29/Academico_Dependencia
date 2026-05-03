using Academico_Dependencia.Models;
using Academico_Dependencia.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Academico_Dependencia.Controllers
{
    public class AcademicoController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;

        public AcademicoController(IAlunoRepository repository)
        {
            _alunoRepository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // GET: Aluno
        public IActionResult Aluno()
        {
            return View();
        }

        // POST: Aluno
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Aluno([Bind("Nome,Email,Telefone,Endereco,Complemento,Bairro,Municipio,Uf,Cep")] Aluno aluno)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _alunoRepository.Create(aluno);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Não foi possível inserir dados. " + e.Message);
            }
            return View(aluno);
        }

        // GET: Index
        public async Task<IActionResult> Index()
        {
            var alunos = await _alunoRepository.GetAll();
            return View(alunos);
        }

        // GET: Edit
        public async Task<IActionResult> Edit(int id)
        {
            var aluno = await _alunoRepository.GetById(id);
            if (aluno == null)
                return NotFound();
            return View(aluno);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlunoID,Nome,Email,Telefone,Endereco,Complemento,Bairro,Municipio,Uf,Cep")] Aluno aluno)
        {
            try
            {
                if (id != aluno.AlunoID)
                    return NotFound();

                if (ModelState.IsValid)
                {
                    var exists = await _alunoRepository.Exists(id);
                    if (!exists)
                        return NotFound();

                    await _alunoRepository.Edit(aluno);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Ocorreu um erro ao editar o aluno: {ex.Message}");
            }
            return View(aluno);
        }

        // GET: Details
        public async Task<IActionResult> Details(int id)
        {
            var aluno = await _alunoRepository.GetById(id);
            if (aluno == null)
                return NotFound();
            return View(aluno);
        }

        // GET: Delete
        public async Task<IActionResult> Delete(int id)
        {
            var aluno = await _alunoRepository.GetById(id);
            if (aluno == null)
                return NotFound();
            return View(aluno);
        }

        // POST: Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var exists = await _alunoRepository.Exists(id);
                if (!exists)
                    return NotFound();

                await _alunoRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Não foi possível excluir o aluno: {ex.Message}");
            }
            return RedirectToAction(nameof(Index));
        }
    }
}