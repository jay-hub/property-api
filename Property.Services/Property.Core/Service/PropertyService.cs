using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Property.Core.ViewModels;

namespace Property.Core.Service
{
    public interface IPropertyService
    {
        PropertyListViewModel GetPropertyList();
        PropertyViewModel GetPropertyById(int id);
    }
    public class PropertyService : IPropertyService
    {
        private PropertyListViewModel _propertyList = new PropertyListViewModel() {Properties = new List<PropertyViewModel>()};
        public PropertyService()
        {
            _propertyList.Properties.Add(new PropertyViewModel{PropertyId = 1, PropertyArea = 68000, PropertyAddress = "33 York Street", PropertyName = "Glen Maxwell"});
            _propertyList.Properties.Add(new PropertyViewModel{PropertyId = 2, PropertyArea = 21000, PropertyAddress = "99 Yonk Street", PropertyName = "Alex Maxwell"});
            _propertyList.Properties.Add(new PropertyViewModel{PropertyId = 3, PropertyArea = 33000, PropertyAddress = "35 Sea Street", PropertyName = "Amazon"});
            _propertyList.Properties.Add(new PropertyViewModel{PropertyId = 4, PropertyArea = 45000, PropertyAddress = "4 Crescat Street", PropertyName = "Microsoft"});
            _propertyList.Properties.Add(new PropertyViewModel{PropertyId = 5, PropertyArea = 185000, PropertyAddress = "407 Backer Street", PropertyName = "Watson Inc"});
        }

        public PropertyListViewModel GetPropertyList()
        {
            return _propertyList;
        }

        public PropertyViewModel GetPropertyById(int id)
        {
            return _propertyList.Properties.FirstOrDefault(p => p.PropertyId == id);
        }

    }
}
