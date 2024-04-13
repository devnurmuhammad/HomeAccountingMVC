using HomeAccountingMVC.DTOs;
using HomeAccountingMVC.Entities;
using HomeAccountingMVC.Models;

namespace HomeAccountingMVC.Services.Accounts
{
    public interface IAccountService
    {
        bool Create(CreateAccountViewModel viewModel);
        Task<IList<Account>> GetAllAsync();
        Account Update(string username, AccountDTO accountDTO);
        bool Delete(string username, AccountDTO accountDTO);
        Account GetByUsername(string username);
    }
}
