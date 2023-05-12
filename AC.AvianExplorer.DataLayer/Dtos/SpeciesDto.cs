using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Dtos
{
	public class SpeciesDto
	{
        public int SpeciesId { get; set; }
		public string CommonName { get; set;}
		public string SpeciesName { get; set;}
        public string FamilyName { get; set; }
    }

	public class SpeciesAddDto
	{
		public string CommonName { get; set; }
		public string SpeciesName { get; set; }
		public string FamilyName { get; set; }
	}

	public class SpeciesEditDto
	{
		public int SpeciesId { get; set; }
		public string CommonName { get; set; }
		public string SpeciesName { get; set; }
		public string FamilyName { get; set; }
	}
}
