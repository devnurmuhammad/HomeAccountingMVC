using HomeAccountingMVC.Enums.TransactionEnums;

namespace HomeAccountingMVC.Entities
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public TType Type { get; set; }
        public Account Account { get; set; }
        public Category Category { get; set; }
    }
}
