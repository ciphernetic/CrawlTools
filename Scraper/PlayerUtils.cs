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
		/// Returns all distinctly won species.
		/// </summary>
		/// <param name="wins">All wins to analyze.</param>
		/// <returns>Won species.</returns>
		public static IEnumerable<Species> GetWonSpecies(IEnumerable<Win> wins)
		{
			Dictionary<string, Species> rtn = new Dictionary<string, Species>();

			foreach(string c in wins
				.Select(w => w.Character.Substring(0, 2)).Distinct())
			{
				string species = Data.Species.SpeciesMap().ContainsKey(c)
					? Data.Species.SpeciesMap()[c]
					: c;

				// ensures that no duplicates from renames get added.
				if(!rtn.ContainsKey(species))
				{
					rtn.Add(species, Data.Species.GetSpecies()[species]);
				}
			}

			return rtn.Values;
		}
	}
}
