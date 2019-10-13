using System;

namespace BudgetTracker.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int TransactionTypeId { get; set; }
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual TransactionType TranType { get; set; }
    }
}