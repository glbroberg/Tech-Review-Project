using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewProject.Models
{
    public class Brand
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        public virtual ICollection<Review> Review { get; set; }
    }
}