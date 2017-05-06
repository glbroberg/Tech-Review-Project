using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewProject.Models
{
    public class DeviceType
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Device Type")]
        public string DevTypeName { get; set; }

        public virtual ICollection<DeviceType> DevType { get; set; }
    }
}