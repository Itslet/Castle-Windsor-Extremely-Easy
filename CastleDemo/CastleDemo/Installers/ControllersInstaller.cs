﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using System.Web.Mvc;
using CastleDemo.Controllers;

namespace CastleDemo.Installers
{
   
        public class ControllersInstaller : IWindsorInstaller
        {
            public void Install(IWindsorContainer container, IConfigurationStore store)
            {
                container.Register(FindControllers().Configure(ConfigureControllers()));
            }

            private ConfigureDelegate ConfigureControllers()
            {
                return c => c.LifeStyle.Transient;
            }

            private BasedOnDescriptor FindControllers()
            {
                return AllTypes.FromThisAssembly()
                    .BasedOn<IController>()
                    .If(Component.IsInSameNamespaceAs<HomeController>())
                    .If(t => t.Name.EndsWith("Controller"));
            }
        }
    
}