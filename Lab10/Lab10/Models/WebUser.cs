using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab10.Models
{
    public class WebUser
    {
        [Column("UserID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(25), MinLength(3)]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
    }
}
