using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace NGUYENSONGNGAN_5951071062.Models
{
	[DataContract]
	public class WeatherInfo
	{
		[DataMember(Name = "location")]
		public string Location { get; set; }

		[DataMember(Name = "degree")]
		public float Degree { get; set; }

		[DataMember(Name = "datetime")]
		public DateTime Datetime { get; set; }
		public DateTime DateTime { get; internal set; }
		public string Hovaten { get; internal set; }
		public int Mssv { get; internal set; }
	}
}