using HomeAccountingMVC.Entities;
using HomeAccountingMVC.Models;

namespace HomeAccountingMVC.Services.Transactions
{
    public interface ITransactionService
    {
        Task<bool> Create(CreateTransactionViewModel viewModel);
        Task<IList<Transaction>> GetAll();
        Task<bool> Update(Transaction transaction);
        Task<bool> Delete(int ID);
    }
}
