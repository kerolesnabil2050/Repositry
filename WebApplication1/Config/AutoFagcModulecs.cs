﻿using Autofac;
using Ecommerce.Data;
using Ecommerce.Repositry;
using Ecommerce.Services;

public class AutoFacModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<Context>().InstancePerLifetimeScope();
        builder.RegisterType<UnitOfWork>().InstancePerLifetimeScope();

        builder.RegisterGeneric(typeof(Reposity<,>)).As(typeof(IgenricRepo<,>)).InstancePerLifetimeScope();
   builder.RegisterAssemblyTypes(typeof(BranchRepo).Assembly).InstancePerLifetimeScope().InstancePerLifetimeScope();
        builder.RegisterAssemblyTypes(typeof(OrderRepo).Assembly).InstancePerLifetimeScope().InstancePerLifetimeScope();

    }
}
