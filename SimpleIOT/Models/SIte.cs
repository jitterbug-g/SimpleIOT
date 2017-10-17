﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleIOT.Models
{
    public class Site
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Location { get; set; }

        public virtual UserAccount UserAccount { get; set; }
        public virtual List<Cell> Cells { get; set; }
    }
}