using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using P225NLayerArchitectura.Core;
using P225NLayerArchitectura.Core.Repositories;
using P225NLayerArchitectura.Data;
using P225NLayerArchitectura.Data.Repositories;
using P225NLayerArchitectura.Service.Exceptions;
using P225NLayerArchitectura.Service.Implementation;
using P225NLayerArchitectura.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225NLayerArchitectura.Api.Extensions
{
    public static class Extension
    {
        public static void ExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(error =>
            {
                error.Run(async context =>
                {
                    var feature = context.Features.Get<IExceptionHandlerPathFeature>();

                    int statustCode = 500;
                    string errorMessage = "Internal Server Error";

                    if (feature.Error is AlreadyExistException)
                    {
                        statustCode = 409;
                        errorMessage = feature.Error.Message;
                    }
                    else if (feature.Error is ItemNotFountException)
                    {
                        statustCode = 404;
                        errorMessage = feature.Error.Message;
                    }

                    context.Response.StatusCode = statustCode;
                    await context.Response.WriteAsync(errorMessage);
                });
            });
        }

        public static void AddScoppedService(this IServiceCollection services)
        {
            //services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICategoryService, CategoryService>();
        }
    }
}
