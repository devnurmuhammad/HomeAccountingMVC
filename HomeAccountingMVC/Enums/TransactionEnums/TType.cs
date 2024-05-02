using System.ComponentModel.DataAnnotations;

namespace HomeAccountingMVC.Enums.TransactionEnums
{
    public enum TType
    {
        [Display(Name = "Income")]
        Income = 1,
        Outcome,
    }
}
