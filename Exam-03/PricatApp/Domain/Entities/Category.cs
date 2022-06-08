using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities
{
    public class Category : EntityBase
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
