using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependecyResolvers.Autofac
{
    /// <summary>
    /// startupta yazilan IoC kodlarini bu kisimda yazacagiz
    /// </summary>
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // biri senden service isterse manager ver
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<efProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
