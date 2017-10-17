using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleIOT.Models
{
    public class Cell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual Site Site { get; set; }
        public virtual List<Device> Devices { get; set; }
    }
}