using HomeAccountingMVC.Models;
using HomeAccountingMVC.Services.Transactions;
using Microsoft.AspNetCore.Mvc;

namespace HomeAccountingMVC.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionService _service;

        public TransactionController(ITransactionService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateTransactionViewModel model)
        {
            if (ModelState.IsValid)
            {
                _service.Create(model);
                return View(model);
            }

            throw new Exception("not valid");
        }
    }
}
