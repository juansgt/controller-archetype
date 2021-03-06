﻿using Container;
using ControllerArchetype.Services.AccountService;
using DataAccess.AccountDao;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Routing;
using Unity;

namespace ControllerArchetype
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //GlobalConfiguration.Configure(WebApiConfig.Register);
            ContainerService.Instance.GetUnityContainer().RegisterType<IAccountService, AccountServiceProxy>();
            ContainerService.Instance.GetUnityContainer().RegisterType<IAccountDao, AccountDaoMongoDB>();

            //Enabling Attribute Routing
            GlobalConfiguration.Configuration.MapHttpAttributeRoutes();

            //var appXmlType = GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            //GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);

            //Quitar serializazado XML
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

            //Para poder hacer llamadas ajax desde orígenes diferentes (una url a otra)
            var cors = new EnableCorsAttribute("*", "*", "*");
            GlobalConfiguration.Configuration.EnableCors(cors);

            //Web api serializer settings
            //GlobalConfiguration.Configuration.Formatters.XmlFormatter.UseXmlSerializer = true;

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.None;
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
            ((DefaultContractResolver)GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ContractResolver).IgnoreSerializableAttribute = true;
            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.UseDataContractJsonSerializer = true;

            GlobalConfiguration.Configuration.EnsureInitialized();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
