using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LB.ProjetoAgenda.Application.ViewModel;
using LB.ProjetoAgenda.MVC.Models;

namespace LB.ProjetoAgenda.MVC.Controllers
{
    public class ServicosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Servicos
        public ActionResult Index()
        {
            return View(db.ServicoViewModels.ToList());
        }

        // GET: Servicos/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicoViewModel servicoViewModel = db.ServicoViewModels.Find(id);
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
        public ActionResult Create([Bind(Include = "ServicoId,NomeServico")] ServicoViewModel servicoViewModel)
        {
            if (ModelState.IsValid)
            {
                servicoViewModel.ServicoId = Guid.NewGuid();
                db.ServicoViewModels.Add(servicoViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicoViewModel);
        }

        // GET: Servicos/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicoViewModel servicoViewModel = db.ServicoViewModels.Find(id);
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
        public ActionResult Edit([Bind(Include = "ServicoId,NomeServico")] ServicoViewModel servicoViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicoViewModel).State = EntityState.Modified;
                db.SaveChanges();
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
            ServicoViewModel servicoViewModel = db.ServicoViewModels.Find(id);
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
            ServicoViewModel servicoViewModel = db.ServicoViewModels.Find(id);
            db.ServicoViewModels.Remove(servicoViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
