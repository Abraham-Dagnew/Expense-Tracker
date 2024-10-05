using System.ComponentModel.DataAnnotations;

namespace Expense_Tracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal value { get; set; }
        [Required]

        public string? Description { get; set; }

        
    }
}
