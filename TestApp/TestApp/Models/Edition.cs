using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Models
{
    public class Edition
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    
}
