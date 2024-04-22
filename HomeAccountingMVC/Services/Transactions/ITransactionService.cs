using HomeAccountingMVC.Entities;

namespace HomeAccountingMVC.Services.Transactions
{
    public interface ITransactionService
    {
        Task<bool> Create(Transaction transaction);
        Task<IList<Transaction>> GetAll();
        Task<bool> Update(Transaction transaction);
        Task<bool> Delete(int ID);
    }
}
