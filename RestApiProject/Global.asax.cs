using Autofac;
using DTO;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace RestApiProject
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ConfigureAutofac();
        }

        private void ConfigureAutofac()
        {

            var builder = new ContainerBuilder();

            builder.RegisterType<ProductService>().As<IBaseService<ProductDTO>>();
            builder.RegisterType<ProductTypeService>().As<IBaseService<ProductTypeDTO>>();
            builder.RegisterType<ProductDiscountService>().As<IBaseService<ProductDiscountDTO>>();
            builder.RegisterType<DiscountService>().As<IBaseService<DiscountDTO>>();
            builder.RegisterType<VariationService>().As<IBaseService<VariationDTO>>();

            var container = builder.Build();

        }
    }
}
