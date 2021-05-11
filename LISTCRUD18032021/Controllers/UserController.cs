using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LISTCRUD18032021.Models;

namespace LISTCRUD18032021.Controllers
{
    public class UserController : Controller
    {
        public static List<Employee> tempListData = new List<Employee>();
        // GET: User
        public UserController()
        {
            if (tempListData.Count() == 0)
            {
                tempListData.Add(new Employee() { Id = 1, name = "abc", City = "Snagar", Country = "USA" });
                tempListData.Add(new Employee() { Id = 2, name = "EFG", City = "surat", Country = "USA" });
                tempListData.Add(new Employee() { Id = 3, name = "XYZ", City = "rajkot", Country = "USA" });
            }
    }
        
        public ActionResult Index()
        {
            return View(tempListData.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                //var tempId = tempListData.ToList().OrderByDescending(a => a.Id).FirstOrDefault();
                //if (tempId != null)
                //{
                //    emp.Id = tempId.Id + 1;
                //}
                //else
                //{
                //    emp.Id = 1;
                //}
                tempListData.Add(emp);
            }
            return View("index", tempListData);
        }
        
        
        
        public ActionResult Edit(int id)
        {
            return View(tempListData.Where(a => a.Id.Equals(id)).FirstOrDefault());
        }
        
        
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            var empdata = tempListData.Where(a => a.Id.Equals(emp.Id)).FirstOrDefault();

            empdata.name = emp.name;
            empdata.City = emp.City;
            empdata.Country = emp.Country;

            return RedirectToAction("Index");
        }

      
        public ActionResult Details(int id)
        {
            return View(tempListData.Where(a => a.Id.Equals(id)).FirstOrDefault());
        }
       
        public ActionResult Delete(int id)
        {
            var empdata = tempListData.Where(a => a.Id.Equals(id)).FirstOrDefault();
            if (empdata != null)
            {
                tempListData.Remove(empdata);
                
            }
            return View("index", tempListData);
        }
    }
}