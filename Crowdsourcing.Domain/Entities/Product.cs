using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
        [MaxLength(50)]

        public string Name { get; set; }

        public int? ManagerId { get; set; }

        [ForeignKey("ManagerId ")]
        public virtual Manager Manager { get; set; }
    }
}
