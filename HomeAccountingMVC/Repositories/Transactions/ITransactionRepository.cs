using HomeAccountingMVC.Entities;

namespace HomeAccountingMVC.Repositories.Transactions
{
    public interface ITransactionRepository
    {
        Task<bool> Create(Transaction transaction);
        Task<IList<Transaction>> GetAll();
        Task<bool> Update(Transaction transaction);
        Task<bool> Delete(int ID);
        Transaction GetByID(int ID);

    }
}
