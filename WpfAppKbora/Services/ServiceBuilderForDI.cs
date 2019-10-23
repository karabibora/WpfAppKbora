
using Microsoft.Extensions.DependencyInjection;
using DATA;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using WpfAppKbora.Models;
using AutoMapper.Attributes;

namespace WpfAppKbora.Services
{
    public static class ServiceBuilderForDI
    {
        private static ServiceCollection _services;
        // steps to use DI
        public static ServiceProvider LoadServiceProvider()
        {
            // create service collection
            //var services = new ServiceCollection();
            if (_services == null)
            {
                _services = new ServiceCollection();
                // add EF , also added a contructor to accept Options on  .OriginKBContext
                _services.AddDbContext<OriginKBContext>(options => options.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Origin;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True"));
            }
            // build service provider and return
            return _services.BuildServiceProvider();
            //}

        }
    }
}