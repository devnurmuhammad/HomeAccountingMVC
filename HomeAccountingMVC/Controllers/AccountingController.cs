using HomeAccountingMVC.Db_Context;
using HomeAccountingMVC.Entities;
using HomeAccountingMVC.Models;
using HomeAccountingMVC.Services.Accounts;
using Microsoft.AspNetCore.Mvc;

namespace HomeAccountingMVC.Controllers
{
    public class AccountingController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly ApplicationDbContext _context;

        public AccountingController(IAccountService accountService, ApplicationDbContext context)
        {
            _accountService = accountService;
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateAccountViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _accountService.Create(viewModel);
                return View();
            }
            throw new Exception("not valid");
        }

        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            IList<Account> accounts = await _accountService.GetAllAsync();

            return View(accounts);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Account? result = _accountService.GetByID(id);

            return View(result);
        }

        [HttpPost]
        public IActionResult Update(Account account)
        {
            if (!ModelState.IsValid)
            {
                _accountService.Update(account);

                return RedirectToAction("GetAccounts", "Accounting");
            }
            throw new Exception("not valid");
        }

        [HttpPost]
        public IActionResult Delete(Account account)
        {
            _accountService.Delete(account.ID);

            return RedirectToAction("GetAccounts", "Accounting");
        }
    }
}
