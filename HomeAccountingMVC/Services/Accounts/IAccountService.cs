using HomeAccountingMVC.Entities;
using HomeAccountingMVC.Models;

namespace HomeAccountingMVC.Services.Accounts
{
    public interface IAccountService
    {
        bool Create(CreateAccountViewModel viewModel);
        Task<IList<Account>> GetAllAsync();
        Account Update(Account account);
        bool Delete(int id);
        Account GetByUsername(string username);
        Account GetByID(int id);
    }
}
