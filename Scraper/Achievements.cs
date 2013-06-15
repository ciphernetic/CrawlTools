using System;
using System.Collections.Generic;
using System.Linq;

namespace Crawl.Scraper
{
	public static class Achievements
	{
		/// <summary>
		/// Determines if the player has one with every available god.
		/// </summary>
		/// <returns>True if players has won with every god.</returns>
		public static bool IsPolytheist(List<Win> wins)
		{
			God gods = 0;

			foreach(God g in Enum.GetValues(typeof(God)).Cast<God>())
			{
				if(null != wins.FirstOrDefault(w =>
					w.God.Replace(" ", string.Empty) ==
					(g == God.NoGod ? string.Empty : g.ToString())))
				{
					gods |= g;
				}
			}

			return gods == God.All;
		}

		/// <summary>
		/// Determines if the player has won at least 10 games.
		/// </summary>
		/// <returns>True if player has won 10 or more games.</returns>
		public static bool IsGoodPlayer(List<Win> wins)
		{
			return wins.Count >= 10;
		}
	}
}
