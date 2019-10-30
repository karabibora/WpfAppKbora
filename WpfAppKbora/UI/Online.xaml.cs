using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using AutoMapper.QueryableExtensions;
using Microsoft.Extensions.DependencyInjection;
using WpfAppKbora.Models;
using AutoMapper;
using AutoMapper.Attributes;
using WpfAppKbora.Services;
using DATA;

namespace CusaInWPF.UI
{
	/// <summary>
	/// Interaction logic for Online.xaml
	/// </summary>
	public partial class Online : Page
	{
		public OriginKBContext _dbContext;
		public Online()
		{
			InitializeComponent();
			// use DI
			_dbContext = ServiceBuilderForDI.LoadServiceProvider().GetService<OriginKBContext>();

			LoadData();
		}
		public Online(OriginKBContext dbContext)
		{
			InitializeComponent();


		//	_dbContext = dbContext;

			LoadData();
		}
		private void LoadData()
		{

            //var accts = _dbContext.Departments.Where(x => x.Ckey == "1" &&(  x.ShareType != string.Empty)).ProjectTo<AccountGetModel>().ToList();
            var accts = _dbContext.Departments.Where(x => x.Name == "Department 1").ProjectTo<DepartmentGetModel>().ToList();
            if (accts.Count > 0)
			{
				//data binding to the control
				dataGridMain.ItemsSource = accts;
			}
		}
	}
}

