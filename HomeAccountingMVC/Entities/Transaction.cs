using HomeAccountingMVC.Enums.TransactionEnums;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace HomeAccountingMVC.Entities
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public TType Type { get; set; }
        public int Sum { get; set; }
        public string Comment { get; set; }
        public int AccountID { get; set; }
        public int CategoryID { get; set; }

        [ForeignKey(nameof(AccountID))]
        public Account Account { get; set; }
        [ForeignKey(nameof(CategoryID))]
        public Category Category { get; set; }
    }
}
