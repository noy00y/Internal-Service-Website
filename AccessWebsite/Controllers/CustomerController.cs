using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using AccessWebsite.Data;
using AccessWebsite.Models;
using AccessWebsite.Models.Advantage;
using AccessWebsite.Data.Data_Providers;
using AccessWebsite.Services;
using Microsoft.EntityFrameworkCore;

namespace AccessWebsite.Controllers
{
    public class CustomerController : Controller
    {
        // Injections
        private readonly ICustomerService _customerService;
        private readonly IDirectSalesOrderHeaderDataProvider _orderHeaderData;

        public CustomerController(ICustomerService customerService, IDirectSalesOrderHeaderDataProvider orderHeaderData)
        {
            _customerService = customerService;
            _orderHeaderData = orderHeaderData;
        }

        // GET: CustomerController
        public IActionResult Index(string searchString)
        {
            return View(_customerService.GetCustomers(searchString));
        }

        // Search for Single Customer
        public IActionResult Search(string id)
        {
            Customer cx = _customerService.GetCustomer(id);
            List<Customer> customer = new List<Customer> { cx };
            return View("Index", customer);
        }

        // GET: CustomerController/Create   
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Models.Advantage.Customer obj)
        {
            return View();
        }

        // GET: CustomerController/Edit/
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Details/id
        [Route("Customer/Details/{id:maxlength(10)}")]
        public ActionResult Details(string id)
        {
            // View Model:
            VMCustomerOrderHeader model =  new VMCustomerOrderHeader();

            // Get Customer and Associated Orders
            model.customer = _customerService.GetCustomer(id);
            model.orders = _orderHeaderData.getHeaders(id);

            // Return to View:
            return View(model);
        }
    }
}
