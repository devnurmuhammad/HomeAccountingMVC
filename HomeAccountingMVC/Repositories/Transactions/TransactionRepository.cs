using HomeAccountingMVC.Db_Context;
using HomeAccountingMVC.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAccountingMVC.Repositories.Transactions
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationDbContext _context;

        public TransactionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Create(Transaction transaction)
        {
            await _context.Transactions.AddAsync(transaction);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<bool> Delete(int ID)
        {
            Transaction? transaction = await _context.Transactions.FindAsync(ID);
            _context.Transactions.Remove(transaction);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }

        public async Task<IList<Transaction>> GetAll()
        {
            IList<Transaction> transactions = await _context.Transactions.ToListAsync();

            return transactions;
        }

        public Transaction GetByID(int ID)
        {
            Transaction? transaction = _context.Transactions.Find(ID);

            return transaction;
        }

        public async Task<bool> Update(Transaction transaction)
        {
            _context.Transactions.Update(transaction);
            int result = await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
