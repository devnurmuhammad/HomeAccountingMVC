using HomeAccountingMVC.Entities;
using HomeAccountingMVC.Models;
using HomeAccountingMVC.Services.Accounts;
using Microsoft.AspNetCore.Mvc;

namespace HomeAccountingMVC.Controllers
{
    public class AccountingController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateAccountViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                _accountService.Create(viewModel);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            IList<Account> accounts = await _accountService.GetAllAsync();

            return View(accounts);
        }
    }
}
