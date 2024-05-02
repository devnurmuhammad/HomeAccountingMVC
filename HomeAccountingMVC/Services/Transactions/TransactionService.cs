using HomeAccountingMVC.Entities;
using HomeAccountingMVC.Models;
using HomeAccountingMVC.Repositories.Transactions;

namespace HomeAccountingMVC.Services.Transactions
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;

        public TransactionService(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Create(CreateTransactionViewModel viewModel)
        {
            Transaction transaction = new Transaction()
            {
                CreatedDate = DateTime.Now,
                Type = viewModel.Type,
                AccountID = viewModel.AccountID,
                CategoryID = viewModel.CategoryID,
            };

            bool result = await _repository.Create(transaction);

            return result;
        }

        public Task<bool> Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Transaction>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
