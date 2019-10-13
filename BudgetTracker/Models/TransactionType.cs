using System;

namespace BudgetTracker.Models
{
    public class TransactionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int ExpenseTypeId { get; set; }

        public virtual ExpenseType ExpType { get; set; }
    }
}