﻿using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Trader.Infrastructure.Names;
using Trader.Modules.Greenblatt.Models;
using Trader.Modules.Greenblatt.ViewModels;
 
namespace Trader.Modules.Greenblatt
{
    public class Greenblatt : IModule
    {
        private readonly IRegionManager regionManager;
        private readonly ILoggerFacade logger;
        private readonly IUnityContainer container;

        public Greenblatt(IRegionManager regionManager, ILoggerFacade logger, IUnityContainer container)
        {
            this.regionManager = regionManager;
            this.logger = logger;
            this.container = container;
        }
 
        public void Initialize()
        {
            container.RegisterType<IGreenblattViewModel, GreenblattViewModel>();
            container.RegisterType<IGreenblattModel, GreenblattModel>();

            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(Views.GreenblattView));

            logger.Log("Greenblatt module initialized", Category.Info, Priority.High);
        }
     }
}
