using System;
using System.Collections.Generic;
using System.Text;

namespace Property.Core.ViewModels
{
    public class PropertyListViewModel
    {
        public List<PropertyViewModel> Properties { get; set; }
        public int PageSize { get; set; }
    }
}
