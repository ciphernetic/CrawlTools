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
				Console.WriteLine();
				Console.WriteLine(WinsReport(player));
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
				string.Join(", ", PlayerUtils.GetWonSpecies(player.Wins)
					.Select(s => s.ShortName).OrderBy(s => s)));

			return sb.ToString();
		}

		static string WinsReport(PlayerStats player)
		{
			StringBuilder sb = new StringBuilder();
			foreach(Win win in player.Wins.OrderBy(w => w.Version))
			{
				sb.AppendFormat("Combo: {0}, Runes: {1}, Version {2}\n",
					win.Character, win.NumberOfRunes, win.Version);
			}
			return sb.ToString();
		}
	}
}
