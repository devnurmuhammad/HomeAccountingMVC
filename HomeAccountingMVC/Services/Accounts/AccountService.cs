using HomeAccountingMVC.DTOs;
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

        public bool Delete(string username, AccountDTO accountDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Account>> GetAllAsync()
        {
            IList<Account> accounts = await _repository.GetAllAsync();

            return accounts;
        }

        public Account GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public Account Update(string username, AccountDTO accountDTO)
        {
            throw new NotImplementedException();
        }
    }
}
