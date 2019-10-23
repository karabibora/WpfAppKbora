using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfAppKbora.Services;

namespace WpfAppKbora
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            // add DI and automapper 
            ServiceBuilderForDI.LoadServiceProvider();
            MapperClass.AddMapper();

        }
       
    }
}
