using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NGUYENSONGNGAN_5951071062.Models
{
	[DataContract]
	public class StudentInfo
	{
		[DataMember(Name = "HoVaTen")]

		public string Hovaten { get; set; }
		[DataMember(Name = "MSV")]
		public string Mssv { get; set; }

		[DataMember(Name = "LopHoc")]
		public string Lop { get; set; }

	}
}