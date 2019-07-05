using System;
using System.Collections.Generic;
using System.Text;

namespace Property.Core.ViewModels
{
    public class PropertyViewModel
    {
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyAddress { get; set; }
        public int PropertyArea { get; set; }
    }
}
