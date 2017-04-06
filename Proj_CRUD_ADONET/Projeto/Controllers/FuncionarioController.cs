using System.Web.Mvc;
using Projeto.Models;
using Projeto.Repository;

namespace Projeto.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario/SelecionarFuncionarios
        public ActionResult SelecionarFuncionarios()
        {
            var funcRepository = new FuncionarioRepository();
            ModelState.Clear();

            return View(funcRepository.SelecionarFuncionarios());
        }

        // GET: Funcionario/AdicionarFuncionario
        public ActionResult AdicionarFuncionario()
        {
            return View();
        }

        // POST: Funcionario/AdicionarFuncionario
        [HttpPost]
        public ActionResult AdicionarFuncionario(Funcionario func)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var funcRepository = new FuncionarioRepository();

                    if (funcRepository.AdicionarFuncionario(func))
                    {
                        ViewBag.Message = "Funcionário criado com sucesso!";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/AtualizarFuncionario/5
        public ActionResult AtualizarFuncionario(int id)
        {
            var funcRepository = new FuncionarioRepository();

            return View(funcRepository.SelecionarFuncionarios()
                            .Find(func => func.IdFuncionario == id));
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        public ActionResult AtualizarFuncionario(int id, Funcionario funcionario)
        {
            try
            {
                var funcRepository = new FuncionarioRepository();
                funcRepository.AtualizarFuncionario(funcionario);

                return RedirectToAction("SelecionarFuncionarios");
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/ExcluirFuncionario/5
        public ActionResult ExcluirFuncionario(int id)
        {
            try
            {
                var funcRepository = new FuncionarioRepository();

                if (funcRepository.ExcluirFuncionario(id))
                {
                    ViewBag.AlertMsg = "Funcionário excluído com sucesso.";
                }

                return RedirectToAction("SelecionarFuncionarios");
            }
            catch
            {
                return View();
            }
        }
    }
}
