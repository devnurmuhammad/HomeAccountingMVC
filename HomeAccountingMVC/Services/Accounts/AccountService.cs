using HomeAccountingMVC.Entities;
using HomeAccountingMVC.Models;
using HomeAccountingMVC.Repositories.Accounts;

namespace HomeAccountingMVC.Services.Accounts
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            _repository = repository;
        }

        public bool Create(CreateAccountViewModel accountDTO)
        {
            Account account = new Account()
            {
                Firstname = accountDTO.Firstname,
                Email = accountDTO.Email,
                Username = accountDTO.Username,
                Password = accountDTO.Password,
            };

            bool result = _repository.Create(account);

            return result;
        }

        public bool Delete(int id)
        {
            bool result = _repository.Delete(id);
            if (result)
            {
                return true;
            }
            throw new Exception("Not found");
        }

        public async Task<IList<Account>> GetAllAsync()
        {
            IList<Account> accounts = await _repository.GetAllAsync();

            return accounts;
        }

        public Account GetByID(int id)
        {
            Account account = _repository.GetByID(id);

            if (account is not null)
            {
                return account;
            }
            throw new Exception("not found");
        }

        public Account GetByUsername(string username)
        {
            Account account = _repository.GetByUsername(username);

            return account;
        }

        public Account Update(Account accountDTO)
        {
            Account account = _repository.GetByID(accountDTO.ID);
            if (account is not null)
            {
                account.Firstname = accountDTO.Firstname;
                account.Email = accountDTO.Email;
                account.Username = accountDTO.Username;
                account.Password = accountDTO.Password;

                _repository.Update(account);

                return account;
            }

            throw new Exception("not found");
        }
    }
}
