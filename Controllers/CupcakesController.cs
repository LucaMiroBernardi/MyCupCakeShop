using CupcakeEntity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace CupcakeEntity.Controllers
{
    public class CupcakesController : Controller
    {

        // refernces DBSet in Identity Models
        private ApplicationDbContext context;

        public CupcakesController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: Cupcakes
        public ActionResult Index()
        {
            List<CupcakeModel> cupcakes = context.Cupcakes.ToList();

            return View("Index", cupcakes);
        }

        public ActionResult Details(int id)
        {
            CupcakeModel cupcake = context.Cupcakes.SingleOrDefault(c => c.Id == id);

            return View("Details", cupcake);        
        }


        public ActionResult Create()
        {

            return View("CupcakeForm", new CupcakeModel());
        }

        public ActionResult Edit(int id)
        {
            CupcakeModel cupcake = context.Cupcakes.SingleOrDefault(c => c.Id == id);

            return View("CupcakeForm", cupcake);
        }

        public ActionResult Delete(int id)
        {
            CupcakeModel cupcake = context.Cupcakes.SingleOrDefault(c => c.Id == id);

            context.Entry(cupcake).State = EntityState.Deleted;

            context.SaveChanges();

            return Redirect("/Cupcakes");
        }

        public ActionResult ProcessCreate(CupcakeModel cupcakeModel)
        {
            CupcakeModel cupcake = context.Cupcakes.SingleOrDefault(c => c.Id == cupcakeModel.Id);

            // Edit
            if (cupcake != null)
            {

                cupcake.Name = cupcakeModel.Name;
                cupcake.Price = cupcakeModel.Price;
                cupcake.DateCreated = cupcakeModel.DateCreated;
                cupcake.DateModified = cupcakeModel.DateModified;

            }

            // new item
            else
            {
                context.Cupcakes.Add(cupcakeModel);
            }

            context.SaveChanges();

            return View("Details", cupcakeModel);
        }


        public ActionResult SearchForm()
        {

            return View("SearchForm");
        }

        public ActionResult SearchForName(string searchPhrase)
        {
            var cupcakes = from c in context.Cupcakes where c.Name.Contains(searchPhrase) select c;

            return View("Index", cupcakes);
        }
    }
}