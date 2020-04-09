using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        [Route("Customers")]
        public ActionResult Index()
        {
            List<Customers> CustomersList = new List<Customers>();
            CustomersList.Add(new Customers(0, "Muhamad nasser"));
            CustomersList.Add(new Customers(1, "Ali kaakati"));
            CustomersList.Add(new Customers(2, "Mohamad ali koeik"));
            CustomersList.Add(new Customers(3, "Dr. Mostafa al tamimi"));
            Session["listOfCustomers"] = CustomersList;
            var ListViewModel = new List2ViewModel();
            ListViewModel.ListOfCustomers = CustomersList;
            return View(ListViewModel);
        }
        [Route("Customers/Details/{customerID}")]
        public ActionResult Details(int customerID)
        {
            List<Customers> list = (List<Customers>)Session["listOfCustomers"];
            Customers customer;
            if (list != null)
            {
                customer = list[customerID];
            }
            else
            {
                customer = new Customers(12, "Error");
            }
            return View(customer);
        }

    }
}