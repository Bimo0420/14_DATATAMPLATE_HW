using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATATAMPLATE
{
    public enum AeroPlanes
    {
        Boing,
        Airbus
    }

    public class Brand
    {
        public AeroPlanes AeroPlane { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Capacity { get; set; }
        public string Price { get; set; }
        
    }

}

