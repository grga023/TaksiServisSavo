using Autofac;
using TaksiServis.Repozitoriumi.Context;
using TaksiServis.Repozitoriumi.Interfejsi;
using TaksiServis.Repozitoriumi.Repozitorijumi;
using TaksiServis.Servisi.Interface;
using TaksiServis.Servisi.Servisi;

namespace TaksiServis.KorisnickiInterfejs
{
    internal static class Program
    {
        private static IContainer _container;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Build the dependency injection container
            var builder = new ContainerBuilder();
            builder.RegisterType<TaksiDBCotext>().InstancePerLifetimeScope();
            builder.RegisterType<Servisi.Servisi.TaksiServis>().As<ITaksiServis>();
            builder.RegisterType<TaksiRepozitorijum>().As<ITaksiRepozitory>();
            builder.RegisterType<Form1>().As<Form>();
            // Register other dependencies here
            _container = builder.Build();

            // Resolve the main form from the container
            using var form = _container.Resolve<Form>();
            Application.Run(form);

        }
    }
}