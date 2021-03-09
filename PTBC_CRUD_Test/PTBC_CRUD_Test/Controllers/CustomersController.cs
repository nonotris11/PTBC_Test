using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PTBC_CRUD_Test.Entity;

namespace PTBC_CRUD_Test.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<Customers> m;
            using (var r = new CustomersEntities())
            {
                m = r.Customers.ToList();
            }
            return View(m);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            var Customersmodel = new Customers();
            TryUpdateModel(Customersmodel);

            using (var r = new CustomersEntities())
            {
                r.Customers.Add(Customersmodel);
                r.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var customermodel = new Customers();
            TryUpdateModel(customermodel);

            using (var r = new CustomersEntities())
            {
                customermodel = r.Customers.FirstOrDefault(x => x.Id == id);
            }

            return View(customermodel);
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_Get(int id)
        {
            var customermodel = new Customers();
            TryUpdateModel(customermodel);

            using (var r = new CustomersEntities())
            {
                customermodel = r.Customers.Where(x => x.Id == id).FirstOrDefault();
            }

            return View(customermodel);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            var customermodel = new Customers();
            TryUpdateModel(customermodel);

            using (var r = new CustomersEntities())
            {
                var m = r.Customers.Where(x => x.Id == id).FirstOrDefault();
                TryUpdateModel(m);
                r.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public ActionResult Delete_Get(int id)
        {
            var customermodel = new Customers();
            TryUpdateModel(customermodel);

            using (var r = new CustomersEntities())
            {
                customermodel = r.Customers.FirstOrDefault(x => x.Id == id);
            }

            return View(customermodel);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Post(int id)
        {
            var customermodel = new Customers();
            TryUpdateModel(customermodel);

            using (var r = new CustomersEntities())
            {
                var m = r.Customers.Remove(r.Customers.FirstOrDefault(x => x.Id == id));
                TryUpdateModel(m);
                r.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}