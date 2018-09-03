using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDB
{
    class Product
    {
        public int ProductID{ get; set; }
        [Required]
        [StringLength(40)]
        public string ProductName { get; set; }
        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
