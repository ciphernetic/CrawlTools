using System;
using System.Linq;
using System.Text;

using Crawl.Scraper;

namespace Crawl.Scraper.CLI
{
	class Program
	{
		static void Main(string[] args)
		{
			PlayerStats player = new PlayerStats("palyth");
			Console.WriteLine(BuildReport(player));
		}

		static string BuildReport(PlayerStats player)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Player: {0}\n", player.PlayerName);
			sb.AppendFormat("Number of wins: {0}\n", player.Wins.Count);
			sb.AppendFormat("Is good player: {0}\n", player.IsGoodPlayer());
			sb.AppendFormat("Is polytheist: {0}\n", player.IsPolytheist());
			sb.AppendFormat("Unique combos won: {0}\n",
				player.Wins.Select(w => w.Character).Distinct().Count());

			return sb.ToString();
		}
	}
}
