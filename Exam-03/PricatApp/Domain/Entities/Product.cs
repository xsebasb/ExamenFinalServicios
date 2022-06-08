using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Domain.Common;

namespace Domain.Entities
{
    public class Product : EntityBase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string EanCode { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public decimal Price { get; set; }


    }
}
