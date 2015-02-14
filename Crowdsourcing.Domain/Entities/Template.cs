using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crowdsourcing.Domain.Entities
{
    public class Template
    {
        [Key, ForeignKey("Manager")]
        public int ManagerId { get; set; }

        [Required(ErrorMessage = "Name Required")]
        [StringLength(25, ErrorMessage = "Must be less than 25 characters")]
        [MaxLength(50)]
        public string ProjectName { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public string WelcomeText { get; set; }
        public string TemplateColor { get; set; }
        public string FormatText { get; set; }

        public virtual Manager Manager { get; set; }
    }
}
