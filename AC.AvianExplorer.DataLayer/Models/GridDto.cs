using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Dtos
{
	public class GridDto
	{
        public int UserId { get; set; }
        public string LocationName { get; set; }
		public string FamilyName { get; set; }
        public string CommonName { get; set; }
        public int Total { get; set; }
    }
}
