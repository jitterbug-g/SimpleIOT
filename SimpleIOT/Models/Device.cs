using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleIOT.Models
{
    public class Device
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public virtual Cell Cell { get; set; }
        [Required]
        public virtual DeviceType DeviceType { get; set; }


    }
}