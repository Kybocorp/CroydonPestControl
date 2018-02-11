using CroydonPestControl.API.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace CroydonPestControl.API
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseOptions(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<OptionsMiddleware>();
        }
    }
}
  
