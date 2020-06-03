using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace product_web_app.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct { get; set; }

        [Display(Name = "Product Code")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required")]
        public string ProductCode { get; set; }

        [Display(Name = "Product Type")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is required")]
        public string ProductType { get; set; }

        [Display(Name = "Description")]
        [StringLength(150)]
        public string Description { get; set; }

        [Display(Name = "Product Price")]
        [Required(ErrorMessage = "{0} is required")]
        [DisplayFormat(DataFormatString="{0:C}")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Quantity in Stock")]
        [Required(ErrorMessage = "{0} is required")]
        public int QtyInStock { get; set; }
    }
}