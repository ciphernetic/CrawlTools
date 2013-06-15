using System;
using System.Collections.Generic;
using System.Linq;

namespace Crawl.Scraper
{
	public static class PlayerUtils
	{
		/// <summary>
		/// Returns a flagged enum of all won gods.
		/// </summary>
		/// <param name="wins">All wins to analyze.</param>
		/// <returns>Flagged God enum.</returns>
		public static God GetWonGods(IEnumerable<Win> wins)
		{
			God rtn = 0;

			foreach(string god in wins
				.Select(w => w.God.Replace(" ", string.Empty)).Distinct())
			{
				if(string.Empty == god)
				{
					rtn |= God.NoGod;
				}
				else
				{
					rtn |= (God)Enum.Parse(typeof(God), god, true);
				}
			}

			return rtn;
		}

		/// <summary>
		/// Returns a flagged enum of all won species. Renamed species return
		/// as current name.
		/// </summary>
		/// <param name="wins">All wins to analyze.</param>
		/// <returns>Flagged Species enum.</returns>
		public static Species GetWonSpecies(IEnumerable<Win> wins)
		{
			Species rtn = 0;

			foreach(Species s in wins
				.Select(w => (Species)Enum.Parse(typeof(Species),
					w.Character.Substring(0, 2)))
				.Distinct())
			{
				if(Species.Ke == s)
				{
					rtn |= Species.Te;
				}
				else
				{
					rtn |= s;
				}
			}

			return rtn;
		}
	}
}
