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
            //System.Windows.Forms.Application.Run(new ShowProduct());
            System.Windows.Forms.Application.Run(new LoginForm());
            //System.Windows.Forms.Application.Run(new AdminDashBord());
        }
    }
}