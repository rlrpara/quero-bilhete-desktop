using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using QueroBilhete.Infra.CrossCutting;
using QueroBilhete.Service.AutoMapper;
using System;
using System.Windows.Forms;

namespace QueroBilhete.Desktop
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeAutomapper();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            ConfigureServices();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }
        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            ServiceProvider = services.BuildServiceProvider();
        }

        private static void InitializeAutomapper()
        {
            var _mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperSetup());
            });
        }
    }
}
