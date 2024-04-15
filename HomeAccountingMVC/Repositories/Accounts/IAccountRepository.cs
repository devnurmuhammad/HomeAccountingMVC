using HomeAccountingMVC.Entities;

namespace HomeAccountingMVC.Repositories.Accounts
{
    public interface IAccountRepository
    {
        bool Create(Account account);
        Task<IList<Account>> GetAllAsync();
        Account Update(Account account);
        bool Delete(int id);
        Account GetByUsername(string username);
        Account GetByID(int id);
    }
}
