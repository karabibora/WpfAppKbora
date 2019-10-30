using AutoMapper;
using AutoMapper.Attributes;
using WpfAppKbora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppKbora.Services
{
	public static class MapperClass
	{
		private static bool _initialized;
		public static void  AddMapper()
		{
			if (!_initialized)
			{
				// Add mapper
				Mapper.Initialize(cfg =>
				{
					//cfg.CreateMap<Acct, AcctGetModel>() ; // for regular automap
                    // for attribute auto mapping
					typeof(DepartmentGetModel).Assembly.MapTypes(cfg); 

				});
				_initialized = true;
			}

		}
	}
}
