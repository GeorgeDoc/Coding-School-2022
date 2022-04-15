using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {
    public class Product : BaseEntity {
        [Required]
        public Guid ID { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Cost { get; set; }

        public Product() {

        }
    }
}
