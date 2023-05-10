using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Dtos
{
	public class RecordDto
	{
		public int RecordId { get; set; }
		public int UserId { get; set; }
		public string LocationName { get; set; }
		public string FamilyName { get; set; }
		public string CommonName { get; set; }
		public DateTime RecordTime { get; set; }
		public int Quantity { get; set; }
	}

	public class RecordAddDto
	{
		public int UserId { get; set; }
		public string LocationName { get; set; }
		public string FamilyName { get; set; }
		public string CommonName { get; set; }
		public DateTime RecordTime { get; set; }
		public int Quantity { get; set; }
	}

	public class RecordEditDto
	{
		public int RecordId { get; set; }
		public int UserId { get; set; }
		public string LocationName { get; set; }
		public string FamilyName { get; set; }
		public string CommonName { get; set; }
		public DateTime RecordTime { get; set; }
		public int Quantity { get; set; }
	}
}
