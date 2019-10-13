using System;

namespace BudgetTracker.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public int Limit { get; set; }
        public int TransactionTypeId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual TransactionType TranType { get; set; }
    }
}