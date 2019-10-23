using AutoMapper.Attributes;
//using CusaDataEF.Entities;
using DATA.Model;
using System;

namespace WpfAppKbora.Models
{
	[MapsTo(typeof(Departments))]
	public class DepartmentGetModel
	{
        public string Name { get; set; }
        public DateTimeOffset ModifyTimestamp { get; set; }
        public string ModifyHostName { get; set; }
        public string ModifyEmail { get; set; }
        public string ModifyBy { get; set; }
        public string ModifyApplication { get; set; }
        public FinancialInstitutions FinancialInstitution { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset CreateTimestamp { get; set; }
        public string CreateHostName { get; set; }
        public string CreateEmail { get; set; }
        public string CreateBy { get; set; }
        public string CreateApplication { get; set; }
        public Guid Id { get; set; }
    }
}
