using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Dtos
{
	public class LocationDto
	{
		public int LocationId { get; set; }
		public string LocationName { get; set; }
        public int UserId { get; set; }
    }



	public class LocationAddDto
	{
		public string LocationName { get; set; }
		public int UserId { get; set; }
	}

	public class LocationEditDto
	{
		public int LocationId { get; set; }
		public string LocationName { get; set; }
		public int UserId { get; set; }
	}
}
