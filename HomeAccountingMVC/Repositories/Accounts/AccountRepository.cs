using HomeAccountingMVC.Db_Context;
using HomeAccountingMVC.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAccountingMVC.Repositories.Accounts
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Create(Account account)
        {
            _context.Accounts.Add(account);
            int result = _context.SaveChanges();

            return result > 0;
        }

        public bool Delete(int id)
        {
            Account? account = _context.Accounts.FirstOrDefault(x => x.ID == id);
            _context.Accounts.Remove(account);
            int result = _context.SaveChanges();

            return result > 0;
        }

        public async Task<IList<Account>> GetAllAsync()
        {
            IList<Account> accounts = await _context.Accounts.ToListAsync();

            return accounts;
        }

        public Account GetByID(int id)
        {
            Account? account = _context.Accounts.Find(id);

            return account;
        }

        public Account GetByUsername(string username)
        {
            Account? account = _context.Accounts.FirstOrDefault(x => x.Username == username);
           
            return account;
        }

        public Account Update(Account account)
        {
            _context.Accounts.Update(account);
            _context.SaveChanges();
            return account;
        }
    }
}
