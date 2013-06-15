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
	}
}
