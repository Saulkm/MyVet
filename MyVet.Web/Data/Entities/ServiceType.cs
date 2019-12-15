using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Display(Name = "Service Type")]
        [MaxLength(50, ErrorMessage = "The {0} field cant not have more than {1} characters")]
        [Required(ErrorMessage = "The field {0} is mandatory")]
        public int Name { get; set; }

        public ICollection<History> Histories { get; set; }

    }
}
