using Camp.Business;
using Camp.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camp.API.Filters
{
    public class CampExistAttribute :TypeFilterAttribute
    {
        public CampExistAttribute() :base(typeof(CampExistingFilter))
        {

        }
        private class CampExistingFilter : IAsyncActionFilter
        {
            private ICampService campService;
            
           
            public CampExistingFilter(ICampService campService)
            {
                this.campService = campService;
            }
            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {

                if (!context.ActionArguments.ContainsKey("id")) 
                {
                    context.Result = new BadRequestResult();
                    return;
                }
                if (!(context.ActionArguments["id"] is int id))
                {
                    context.Result = new BadRequestResult();
                    return;
                }

              
                await next();
            }
        }
    }
}
