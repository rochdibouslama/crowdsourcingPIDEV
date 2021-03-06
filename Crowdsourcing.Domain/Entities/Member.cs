﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entities
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
        [MaxLength(50)]
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

        public int? ManagerId { get; set; }

        [ForeignKey("ManagerId ")]
        public virtual Manager Manager { get; set; }
    }
}
