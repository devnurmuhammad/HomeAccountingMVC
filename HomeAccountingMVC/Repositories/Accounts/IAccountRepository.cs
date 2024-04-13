using HomeAccountingMVC.Entities;

namespace HomeAccountingMVC.Repositories.Accounts
{
    public interface IAccountRepository
    {
        bool Create(Account account);
        Task<IList<Account>> GetAllAsync();
        Account Update(Account account);
        bool Delete(string username);
        Account GetByUsername(string username);
    }
}
