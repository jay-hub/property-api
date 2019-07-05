using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Property.Core.Service;

namespace Property.Api.Controllers
{
    [EnableCors("MyPolicy")]
    public class PropertiesController : Controller
    {
        private IPropertyService _propertyService;
        public PropertiesController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [Route("api/properties")]
        public JsonResult GetPropertyList()
        {
            return Json(_propertyService.GetPropertyList());
        }

        [Route("api/properties/{id}")]
        public ActionResult GetPropertyById(int id)
        {
            return Json(_propertyService.GetPropertyById(id));
        }
    }
}