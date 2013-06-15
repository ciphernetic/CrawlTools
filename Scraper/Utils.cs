using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crawl.Scraper
{
	public static class Utils
	{
		public static IEnumerable<Species> GetAllSpecies(Version version)
		{
			return Data.Species.GetSpecies().Values
				.Where(s => (s.Active && s.FirstVersion.CompareTo(version) <= 0)
					|| (!s.Active && s.LastVersion.CompareTo(version) >= 0));
		}
	}
}
