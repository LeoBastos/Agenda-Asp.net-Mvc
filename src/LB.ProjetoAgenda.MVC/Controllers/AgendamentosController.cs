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
    public class AgendamentosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Agendamentos
        public ActionResult Index()
        {
            return View(db.AgendamentoViewModels.ToList());
        }

        // GET: Agendamentos/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendamentoViewModel agendamentoViewModel = db.AgendamentoViewModels.Find(id);
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
        public ActionResult Create([Bind(Include = "AgendamentoId,DataAgendamento,HoraInicial,HoraFinal,Tipo,FormaPagamento,DataCadastroAgendamento")] AgendamentoViewModel agendamentoViewModel)
        {
            if (ModelState.IsValid)
            {
                agendamentoViewModel.AgendamentoId = Guid.NewGuid();
                db.AgendamentoViewModels.Add(agendamentoViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agendamentoViewModel);
        }

        // GET: Agendamentos/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendamentoViewModel agendamentoViewModel = db.AgendamentoViewModels.Find(id);
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
        public ActionResult Edit([Bind(Include = "AgendamentoId,DataAgendamento,HoraInicial,HoraFinal,Tipo,FormaPagamento,DataCadastroAgendamento")] AgendamentoViewModel agendamentoViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agendamentoViewModel).State = EntityState.Modified;
                db.SaveChanges();
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
            AgendamentoViewModel agendamentoViewModel = db.AgendamentoViewModels.Find(id);
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
            AgendamentoViewModel agendamentoViewModel = db.AgendamentoViewModels.Find(id);
            db.AgendamentoViewModels.Remove(agendamentoViewModel);
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
