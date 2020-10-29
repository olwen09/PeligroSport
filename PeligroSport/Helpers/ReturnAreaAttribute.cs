﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeligroSport.Helpers
{
    public class ReturnAreaAttribute : ResultFilterAttribute
    {
        private string area;
        public ReturnAreaAttribute(string controlador)
        {
            this.area = controlador;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var viewResult = context.Result as ViewResult;
            if (viewResult != null)
            {
                viewResult.ViewData["area"] = this.area;
            }
        }
    
    }
}
