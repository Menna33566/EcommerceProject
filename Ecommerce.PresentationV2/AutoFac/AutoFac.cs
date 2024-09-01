using Autofac;
using AutoMapper;
using Ecommerce.Application.AutoMapper;
using Ecommerce.Application.Contracts;
using Ecommerce.Application.Services;
using Ecommerce.Context;
using Ecommerce.Inftastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IContainer = Autofac.IContainer;

namespace Ecommerce.PresentationV2.AutoFac
{
    public class AutoFac
    {
        public static IContainer Inject()
        {
            var bulder = new ContainerBuilder();
            bulder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            bulder.RegisterType<UserTypeRepository>().As<IUserTypeRepository>().InstancePerLifetimeScope();
            bulder.RegisterType<ProductRepository>().As<IProductRepository>().InstancePerLifetimeScope();
            bulder.RegisterType<OrderRepository>().As<IOrderRepository>().InstancePerLifetimeScope();
            bulder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerLifetimeScope();
            ///
            bulder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            bulder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            bulder.RegisterType<OrderService>().As<IOrderService>().InstancePerLifetimeScope();
            bulder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            bulder.RegisterType<UserTypeService>().As<IUserTypeService>().InstancePerLifetimeScope();
            ////
            bulder.RegisterType<EcommerceDB>().As<EcommerceDB>();
            ///
            bulder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            }));/*.AsSelf().SingleInstance();*/
            bulder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();
            return bulder.Build();
        }
    }
}
