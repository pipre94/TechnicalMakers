using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Loan
    {
        [Key]
        public string LoanId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }

        [Required]
        public string StatusLoan { get; set; } 

        public DateTime ApprovedDate { get; set; }
        public string? CreatedBy { get; set; } 
        public DateTime? CreatedDate { get; set; } 

        public virtual Login User { get; set; }
    }
}
