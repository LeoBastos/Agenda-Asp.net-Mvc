using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LB.ProjetoAgenda.Application;
using LB.ProjetoAgenda.Application.ViewModel;
using LB.ProjetoAgenda.MVC.Models;

namespace LB.ProjetoAgenda.MVC.Controllers
{
    public class AgendamentosController : Controller
    {
        private readonly AgendamentoAppService _agendamentoAppService;

        public AgendamentosController()
        {
            _agendamentoAppService = new AgendamentoAppService();
        }

        // GET: Agendamentos
        public ActionResult Index()
        {
            return View(_agendamentoAppService.ObterTodos());
        }

        // GET: Agendamentos/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var agendamentoViewModel = _agendamentoAppService.ObterPorId(id.Value);

            if (agendamentoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(agendamentoViewModel);
        }

        // GET: Agendamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Agendamentos/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AgendaViewModel agendaViewModel)
        {
            if (ModelState.IsValid)
            {
                _agendamentoAppService.Adicionar(agendaViewModel);

                return RedirectToAction("Index");
            }

            return View(agendaViewModel);
        }

        // GET: Agendamentos/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var agendamentoViewModel = _agendamentoAppService.ObterPorId(id.Value);
            if (agendamentoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(agendamentoViewModel);
        }

        // POST: Agendamentos/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AgendamentoViewModel agendamentoViewModel)
        {
            if (ModelState.IsValid)
            {
                _agendamentoAppService.Atualizar(agendamentoViewModel);

                return RedirectToAction("Index");
            }
            return View(agendamentoViewModel);
        }

        // GET: Agendamentos/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var agendamentoViewModel = _agendamentoAppService.ObterPorId(id.Value);

            if (agendamentoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(agendamentoViewModel);
        }

        // POST: Agendamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _agendamentoAppService.Remover(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _agendamentoAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
