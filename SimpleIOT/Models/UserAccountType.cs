﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleIOT.Models
{
    public class UserAccountType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<User> Users { get; set; }
        public virtual List<Site> Sites { get; set; }
    }
}