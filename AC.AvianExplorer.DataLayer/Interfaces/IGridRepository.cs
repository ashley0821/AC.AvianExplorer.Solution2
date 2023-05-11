using AC.AvianExplorer.DataLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.AvianExplorer.DataLayer.Interfaces
{
	public interface IGridRepository
	{
		List<GridDto> Search(string locationName, string familyName, string commonName);

		List<GridDto> TopThree(string locationName, string familyName, string commonName);
	}
}
