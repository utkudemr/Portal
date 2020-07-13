
using Busines.Abstract;
using Business.Abstract;
using Entities.Concrete;
using Portal.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {

        ICustomerInsert _customer;
        ICustomerService _repo;
        ICompanyService _company;
        public HomeController(ICustomerInsert customer, ICustomerService repo, ICompanyService company)
        {
            _customer = customer;
            _repo = repo;
            _company = company;
        }
        public ActionResult Index()
        {
           
            return View();
        }
        [AntiProtection]
        public ActionResult Companies()
        {
            var list = _company.GetList();
            return View(list);
        }

        [Protection]
        public ActionResult List()
        {
            var id = int.Parse(Session["compId"].ToString());
            var list = _repo.GetList(id);
            return View(list);
        }

        
        public ActionResult CustomerForm(int compId)
        {
            var compName = _company.Get(compId);
            Session.Add("compId", compId);
            Session.Add("compName", compName.Name);
            return View();
        }

        public ActionResult Close()
        {
            Session.Remove("compId");
            Session.Remove("compName");
            return RedirectToAction("Companies");
        }

        [Protection]
        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            var compId = int.Parse(Session["compId"].ToString());
            customer.CompanyId = compId;
            var response=_customer.Add(customer);
            if(!response)
            {
                ViewBag.ErrorMsg = "Kullanıcı bulunamadı.";
                return View("~/Views/Home/CustomerForm.cshtml");
            }
            else
            {
                return RedirectToAction("List");
            }
            
        }
       
    }
}