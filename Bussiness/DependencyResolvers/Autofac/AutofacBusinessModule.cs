﻿using System;
using Autofac;
using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Bussiness.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
        }
    }
}
