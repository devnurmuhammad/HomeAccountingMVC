using HomeAccountingMVC.Enums.TransactionEnums;

namespace HomeAccountingMVC.Models
{
    public class CreateTransactionViewModel
    {
        public DateTime CreatedDate { get; set; }
        public TType Type { get; set; }
        public int Sum { get; set; }
        public string Comment { get; set; }
        public int AccountID { get; set; }
        public int CategoryID { get; set; }
    }
}
