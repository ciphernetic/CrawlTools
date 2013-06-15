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
			sb.AppendFormat("Is good player: {0}\n", player.IsGoodPlayer());
			sb.AppendFormat("Is polytheist: {0}\n", player.IsPolytheist());
			sb.AppendFormat("Unique combos won: {0}\n",
				player.Wins.Select(w => w.Character).Distinct().Count());

			return sb.ToString();
		}
	}
}
