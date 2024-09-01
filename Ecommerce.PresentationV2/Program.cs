using AutoMapper;
using Ecommerce.Application.Contracts;
using Ecommerce.Application.Services;
using Ecommerce.Application.AutoMapper;
using Ecommerce.Context;
using Ecommerce.Inftastructure;
using System;

namespace Ecommerce.PresentationV2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
             ApplicationConfiguration.Initialize();
            // Application.Run(new ViewOrders(new OrderService(new OrderRepository(new Context.EcommerceDB()), new AutoMapperProfile()), new UserService());

           // Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            // Manually create instances of the required services
            var dbContext = new EcommerceDB(); // Assuming you have your DbContext configured
            var orderRepository = new OrderRepository(dbContext);
            var userRepository = new UserRepository(dbContext);

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>(); // Add your AutoMapper profile
            });
            var mapper = mapperConfig.CreateMapper();

            var orderService = new OrderService(orderRepository, mapper);
            var userService = new UserService(userRepository, mapper);

            // Pass the services to OrderForm
            var orderForm = new orderForm(orderService, userService);

            // Run the OrderForm
            System.Windows.Forms.Application.Run(orderForm);
        }
    }
}