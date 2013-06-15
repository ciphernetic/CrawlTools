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
			return God.All == PlayerUtils.GetWonGods(wins);
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
