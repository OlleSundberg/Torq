﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Torq.Models.Objects
{
	[DataContract]
	public partial class Role
	{
		public Role() => this.Employees = new HashSet<Employee>();
		[Key]
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Title { get; set; }
		[IgnoreDataMember]
		public ICollection<Employee> Employees { get; set; }
	}
}
