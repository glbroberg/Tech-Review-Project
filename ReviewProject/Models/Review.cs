using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewProject.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Comments { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Rating { get; set; }

        [ForeignKey("DeviceType")]
        public int TypeID { get; set; }
        public virtual DeviceType DeviceType { get; set; }


        [ForeignKey("Brand")]
        public int BrandID { get; set; }
        public virtual Brand Brand { get; set; }
    }
}