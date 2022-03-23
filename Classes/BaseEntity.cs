using System.ComponentModel.DataAnnotations;

namespace Classes {
    public abstract class BaseEntity {
        [Required]
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public BaseEntity() {

        }
    }
}