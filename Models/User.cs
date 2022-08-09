using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupportTicket.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string FamilyName { get; set; } = string.Empty;
        public string LoginToken { get; set; } = string.Empty;
        public DateTime? LastLoginDate { get; set; }
        public string UserType { get; set; } = string.Empty;
        public int? ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client? Client { get; set; } 

    }
}

