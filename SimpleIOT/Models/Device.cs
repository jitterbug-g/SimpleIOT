using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleIOT.Models
{
    public class Device
    {
        public int Ic { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public virtual Cell Cell { get; set; }
        public virtual DeviceType DeviceType { get; set; }


    }
}