using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;
using CastleDemo.Infrastructure;

namespace CastleDemo.Installers
{
    public class StoryTellerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
            Component.For<IStoryTeller>().ImplementedBy<FrenchStoryTeller>());
        }
    }
}