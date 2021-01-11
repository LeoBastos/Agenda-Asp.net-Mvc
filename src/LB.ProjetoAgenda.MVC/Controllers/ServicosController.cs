using System;
using System.Net;
using System.Web.Mvc;
using LB.ProjetoAgenda.Application;
using LB.ProjetoAgenda.Application.ViewModel;


namespace LB.ProjetoAgenda.MVC.Controllers
{
    public class ServicosController : Controller
    {
        private readonly ServicoAppService _servicoAppService;

        public ServicosController()
        {
            _servicoAppService = new ServicoAppService();
        }

        // GET: Servicos
        public ActionResult Index()
        {
            return View(_servicoAppService.ObterTodos());
        }

        // GET: Servicos/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var servicoViewModel = _servicoAppService.ObterPorId(id.Value);

            if (servicoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(servicoViewModel);
        }

        // GET: Servicos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servicos/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AgendaViewModel agendaViewModel)
        {
            if (ModelState.IsValid)
            {
                _servicoAppService.Adicionar(agendaViewModel);

                return RedirectToAction("Index");
            }

            return View(agendaViewModel);
        }

        // GET: Servicos/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var servicoViewModel = _servicoAppService.ObterPorId(id.Value);
            
            if (servicoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(servicoViewModel);
        }

        // POST: Servicos/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ServicoViewModel servicoViewModel)
        {
            if (ModelState.IsValid)
            {
                _servicoAppService.Atualizar(servicoViewModel);

                return RedirectToAction("Index");
            }
            return View(servicoViewModel);
        }

        // GET: Servicos/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var servicoViewModel = _servicoAppService.ObterPorId(id.Value);

            if (servicoViewModel == null)
            {
                return HttpNotFound();
            }
            return View(servicoViewModel);
        }

        // POST: Servicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _servicoAppService.Remover(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _servicoAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
