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
			if(1 == args.Length)
			{
				PlayerStats player = new PlayerStats(args[0]);
				Console.WriteLine(BuildReport(player));
			}
			else
			{
				Console.Error.WriteLine("{0} <player name>",
					typeof(Program).Assembly.GetName().Name);
			}
		}

		static string BuildReport(PlayerStats player)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("Player: {0}\n", player.PlayerName);
			sb.AppendFormat("Number of wins: {0}\n", player.Wins.Count);
			sb.AppendFormat("Is good player: {0}\n",
				Achievements.IsGoodPlayer(player.Wins));
			sb.AppendFormat("Is polytheist: {0}\n",
				Achievements.IsPolytheist(player.Wins));
			sb.AppendFormat("Unique combos won: {0}\n",
				player.Wins.Select(w => w.Character).Distinct().Count());
			sb.AppendFormat("Unique gods won: {0}\n",
				PlayerUtils.GetWonGods(player.Wins));
			sb.AppendFormat("Unique species won: {0}\n",
				PlayerUtils.GetWonSpecies(player.Wins));

			return sb.ToString();
		}
	}
}
