using Autofac;
using AutoMapper;
using Ecommerce.Application.AutoMapper;
using Ecommerce.Application.Contracts;
using Ecommerce.Application.Services;
using Ecommerce.Context;
using Ecommerce.Inftastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class AutoFac
    {
        public static IContainer Inject()
        {
            var bulder = new ContainerBuilder();
            bulder.RegisterType<UserRepository>().As<IUserRepository>();
            bulder.RegisterType<UserTypeRepository>().As<IUserTypeRepository>();
            bulder.RegisterType<ProductRepository>().As<IProductRepository>();
            bulder.RegisterType<OrderRepository>().As<IOrderRepository>();
            bulder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
            ///
            bulder.RegisterType<CategoryService>().As<ICategoryService>();
            bulder.RegisterType<ProductService>().As<IProductService>();
            bulder.RegisterType<OrderService>().As<IOrderService>();
            bulder.RegisterType<UserService>().As<IUserService>();
            bulder.RegisterType<UserTypeService>().As<IUserTypeService>();
            bulder.RegisterType<EcommerceDB>().As<EcommerceDB>();
        ////
        bulder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            })).AsSelf().SingleInstance();
        bulder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
            .As<IMapper>()
            .InstancePerLifetimeScope();
            return bulder.Build();
        }
    }

