using HomeAccountingMVC.Enums.CategoryEnums;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAccountingMVC.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public Income Income { get; set; }
        public Outcome Outcome { get; set; }
        public int TransactionID { get; set; }

        [ForeignKey(nameof(TransactionID))]
        public Transaction Transaction { get; set; }
    }
}