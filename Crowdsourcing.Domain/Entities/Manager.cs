using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entities
{
    public class Manager
    {
        [Key]
        public int ManagerId { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
        [MaxLength(25)]
        public string Name { get; set; }


        [Range(0, double.MaxValue)]
        [DataType(DataType.Currency)]
        public double PhoneNumber { get; set; }


        [Range(0, int.MaxValue)]
        public int Age { get; set; }


        [Display(Name = "Birth Date")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set; }


        [Display(Name = "Subscription Date")]
        [DataType(DataType.DateTime)]
        public DateTime SubscriptionDate { get; set; }


        [Required, EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Pseudo Required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
        [MaxLength(25)]
        public string Pseudo { get; set; }

        [Required(ErrorMessage = "Enterprise's name is Required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
        [MaxLength(25)]
        public string EnterpriseName { get; set; }


        public string Image { get; set; }

        public virtual Template Template { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}
